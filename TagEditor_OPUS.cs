using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagEdit.Net
{
    public partial class TagEditor_OPUS : Form
    {
        #region Declaration

        string DBName = string.Empty;
        int cntRecordNo = 0;
        int cntTotalRecords = 0;
        string filePath = string.Empty;
        public OleDbConnection connect = new();//@"Provider=Microsoft.Jet.OleDb.4.0;Data Source= C:\Users\User1\Desktop\test.mdb");

        #endregion

        #region Constructor
        public TagEditor_OPUS()
        {
            InitializeComponent();
            tmrTimer.Enabled = false;
        }

        #endregion

        #region Form Events
        private void TagEditor_OPUS_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - " + Program.MachineName;
            tbxTagEditUser.Text = Program.strUserName;
            tbxTagEditDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            tbxTagEditTime.Text = DateTime.Now.ToString("HH:mm:ss");
            tbxState.Text = Program.StateRTOCode;
            pbxImage.Image = null;
            lblNoDatabaseLoaded.Visible = true;
            lblSelectDatabasefromfilemenu.Visible = true;

            grpSiteData.Visible = false;
            grpVDF.Visible = false;
            grpRecord.Visible = false;

            lblZoomOut.Visible = false;
            lblZoomIn.Visible = false;
            lblShowHotKeys.Visible = false;
            Program.blnDatabase = false;
            if (Program.blnDatabase)
            {
                menuExportCSVDatabase.Enabled = true;
                menuExportCSVNOtice.Enabled = true;
                menuCloseDatabase.Enabled = true;
                menuOpenConsoleDB.Enabled = false;
                menuOpenLiveDB.Enabled = false;
                menuOpenVIDDB.Enabled = false;
            }
            else
            {
                menuExportCSVDatabase.Enabled = false;
                menuExportCSVNOtice.Enabled = false;
                menuCloseDatabase.Enabled = false;
                menuOpenConsoleDB.Enabled = true;
                menuOpenLiveDB.Enabled = false;
                menuOpenVIDDB.Enabled = false;
            }

            cbxVehCatCode.DataSource = Properties.Settings.Default.VehCatCode;
            cbxVehTypeCode.DataSource = Properties.Settings.Default.VehTypeCode;
            cbxVehPlateCode.DataSource = Properties.Settings.Default.VehPlateCode;
            cbxVehMfgCode.DataSource = Properties.Settings.Default.VehMfgCode;

            menuOHIO_Click(menuOHIO, e);
            tmrTimer.Enabled = true;


        }
        private void TagEditor_OPUS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connect.State != ConnectionState.Closed)
                connect.Close();
        }
        private void TagEditor_OPUS_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.blnDatabase)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnVDFAccept_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F2)
                {
                    if (!tbxState.Enabled)
                    {
                        tbxState.Enabled = true;
                        tbxState.Focus();
                    }

                }
                else if (e.KeyCode == Keys.Right)
                {

                    if (this.ActiveControl.Name != "tbxVDFPlate")
                    {
                        cntRecordNo++;
                        if (cntRecordNo >= cntTotalRecords)
                            cntRecordNo = cntTotalRecords - 1;
                        tbxOptionsGoToVDF.Text = (cntRecordNo + 1).ToString();
                        lblVDFNoofRecords.Text = "Record " + (cntRecordNo + 1).ToString() + " of " + cntTotalRecords.ToString();
                        grpVDF.Text = "VDF " + (cntRecordNo + 1).ToString();
                        getRecord(false);
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (this.ActiveControl.Name != "tbxVDFPlate")
                    {
                        cntRecordNo--;
                        if (cntRecordNo < 0)
                            cntRecordNo = 0;
                        tbxOptionsGoToVDF.Text = (cntRecordNo + 1).ToString();
                        lblVDFNoofRecords.Text = "Record " + (cntRecordNo + 1).ToString() + " of " + cntTotalRecords.ToString();
                        grpVDF.Text = "VDF " + (cntRecordNo + 1).ToString();
                        getRecord(false);
                    }
                }
            }

        }

        #endregion

        #region Controls Events

        private void tbxVDFPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8 && Convert.ToInt32(e.KeyChar) != 32)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    tbxVDFPlate.Focus();
                }
            }
            else
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
        private void tbxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8 && Convert.ToInt32(e.KeyChar) != 32)
            {
                e.Handled = true;
                tbxState.Focus();
            }
            else
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
        private void tbxOptionsGoToVDF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tbxTagEditUser.Text = Program.strUserName;
            tbxTagEditDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            tbxTagEditTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void btnVDFAccept_Click(object sender, EventArgs e)
        {
            if (btnVDFAccept.Text == "EDIT (enter)")
            {
                btnVDFAccept.Text = "ACCEPT (enter)";
                tbxVDFPlate.Enabled = true;
                tbxState.Text = Program.StateRTOCode; // "WB";
                tbxState.Enabled = false;
                tbxVDFPlate.Focus();
            }
            else if (btnVDFAccept.Text == "ACCEPT (enter)")
            {
                tbxState.Enabled = false;
                UpdateRecord();
                //cntRecordNo++;
                tbxOptionsGoToVDF.Text = (cntRecordNo + 1).ToString();
                //btnVDFAccept.Text = "EDIT (enter)";
                //tbxVDFPlate.Enabled = false;
                //tbxState.Enabled = false;

                //Right Key
                cntRecordNo++;
                if (cntRecordNo >= cntTotalRecords)
                    cntRecordNo = cntTotalRecords - 1;
                tbxOptionsGoToVDF.Text = (cntRecordNo + 1).ToString();
                lblVDFNoofRecords.Text = "Record " + (cntRecordNo + 1).ToString() + " of " + cntTotalRecords.ToString();
                grpVDF.Text = "VDF " + (cntRecordNo + 1).ToString();
                getRecord(false);

            }
            tbxVDFPlate.SelectAll();
        }
        private void btnOptionsGoToVDF_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxOptionsGoToVDF.Text))
                cntRecordNo = Convert.ToInt32(tbxOptionsGoToVDF.Text);
            cntRecordNo--;
            lblVDFNoofRecords.Text = "Record " + (cntRecordNo + 1).ToString() + " of " + cntTotalRecords.ToString();
            grpVDF.Text = "VDF " + (cntRecordNo + 1).ToString();

            getRecord(true);
        }

        #endregion

        #region Menu's Events

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void menuAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox aboutBox = new frmAboutBox();
            aboutBox.ShowDialog();
        }
        private void menuExportCSVNOtice_Click(object sender, EventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;
            string seqNo = "000";
            string vdfUnit = "";
            string SeqNum = "";
            string folderPath = filePath.Substring(0, filePath.IndexOf(ofdConsoleDB.SafeFileName));
            string picFolderPath = folderPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\Pics\\";
            string fileName = string.Empty;

            if (!Directory.Exists(picFolderPath)) { Directory.CreateDirectory(picFolderPath); }

            DataTable dt = new DataTable();
            dt = getExportNoticeData();


            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["vdfUnit"] != null)
                {
                    vdfUnit = dt.Rows[0]["vdfUnit"].ToString().Substring(0, 4);
                }
                if (dt.Rows[0]["vdfDateTime"] != null)
                {
                    fileName = Convert.ToDateTime(dt.Rows[0]["vdfDateTime"]).ToString("yyyyMMdd");
                }
            }

            foreach (DataColumn column in dt.Columns)
            {
                csv += column.ColumnName + ',';
            }
            //Add new line.
            csv = csv.Substring(0, csv.Length - 1);
            csv += "\r\n";
            //Adding the Rows
            foreach (DataRow row in dt.Rows)
            {
                SeqNum = row["vdfRecordNumber"].ToString();
                //ImageCopyIntoPicsFolder(SeqNum, folderPath, picFolderPath);
                foreach (DataColumn cell in row.Table.Columns)
                {
                    //Add the Data rows.
                    csv += row[cell].ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv = csv.Substring(0, csv.Length - 1);
                csv += "\r\n";
            }


        Loop:
            //string fileNameCSV = folderPath + DateTime.Now.ToString("yyyyMMdd") + "WB-" + vdfUnit + "-" + seqNo + ".csv";
            string fileNameCSV = folderPath + fileName + Program.StateRTOCode + "-" + vdfUnit + "-" + seqNo + ".csv";

            if (File.Exists(fileNameCSV))
            {
                seqNo = fileNameCSV.Substring(fileNameCSV.Length - 7, 3);
                seqNo = Convert.ToString(Convert.ToInt16(seqNo) + 1).PadLeft(3, '0');
                goto Loop;
            }
            File.WriteAllText(fileNameCSV, csv);

            MessageBox.Show("CSV file has been exported successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void menuExportCSVDatabase_Click(object sender, EventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;
            string seqNo = "000";
            string vdfUnit = "";
            string SeqNum = "";
            string folderPath = filePath.Substring(0, filePath.IndexOf(ofdConsoleDB.SafeFileName));
            string picFolderPath = folderPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + "\\Pics\\";
            string fileName = string.Empty;

            if (!Directory.Exists(picFolderPath)) { Directory.CreateDirectory(picFolderPath); }

            DataTable dt = new DataTable();
            dt = getExportData();


            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["vdfUnit"] != null)
                {
                    vdfUnit = dt.Rows[0]["vdfUnit"].ToString().Substring(0, 4);
                }
                if (dt.Rows[0]["vdfDateTime"] != null)
                {
                    fileName = "GasData"+Convert.ToDateTime(dt.Rows[0]["vdfDateTime"]).ToString("yyyyMMdd");
                }
            }

            foreach (DataColumn column in dt.Columns)
            {
                csv += column.ColumnName + ',';
            }
            //Add new line.
            csv = csv.Substring(0, csv.Length - 1);
            csv += "\r\n";
            //Adding the Rows
            foreach (DataRow row in dt.Rows)
            {
                SeqNum = row["vdfRecordNumber"].ToString();
                //ImageCopyIntoPicsFolder(SeqNum, folderPath, picFolderPath);
                foreach (DataColumn cell in row.Table.Columns)
                {
                    //Add the Data rows.
                    csv += row[cell].ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv = csv.Substring(0, csv.Length - 1);
                csv += "\r\n";
            }


        Loop:
            //string fileNameCSV = folderPath + DateTime.Now.ToString("yyyyMMdd") + "WB-" + vdfUnit + "-" + seqNo + ".csv";
            string fileNameCSV = folderPath + fileName + Program.StateRTOCode + "-" + vdfUnit + "-" + seqNo + ".csv";

            if (File.Exists(fileNameCSV))
            {
                seqNo = fileNameCSV.Substring(fileNameCSV.Length - 7, 3);
                seqNo = Convert.ToString(Convert.ToInt16(seqNo) + 1).PadLeft(3, '0');
                goto Loop;
            }
            File.WriteAllText(fileNameCSV, csv);

            MessageBox.Show("CSV file has been exported successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void menuCloseDatabase_Click(object sender, EventArgs e)
        {
            //menuOpenConsoleDB.Enabled = true;
            //menuExportCSVDatabase.Enabled = false;
            TagEditor_OPUS_Load(sender, e);
        }
        private void menuCleanScreen_Click(object sender, EventArgs e)
        {
            DisplayActiveFilters(((ToolStripMenuItem)sender).Text);
            CheckStateUpdate(((ToolStripMenuItem)sender).Text);
        }
        private void menuFilterAll_Click(object sender, EventArgs e)
        {
            DisplayActiveFilters(((ToolStripMenuItem)sender).Text);
            CheckStateUpdate(((ToolStripMenuItem)sender).Text);
        }
        private void menuGrossEmitter_Click(object sender, EventArgs e)
        {
            DisplayActiveFilters(((ToolStripMenuItem)sender).Text);
            CheckStateUpdate(((ToolStripMenuItem)sender).Text);
        }
        private void menuOHIO_Click(object sender, EventArgs e)
        {
            DisplayActiveFilters(((ToolStripMenuItem)sender).Text);
            CheckStateUpdate(((ToolStripMenuItem)sender).Text);
        }
        private void menuShowAll_Click(object sender, EventArgs e)
        {
            DisplayActiveFilters(((ToolStripMenuItem)sender).Text);
            CheckStateUpdate(((ToolStripMenuItem)sender).Text);
        }
        private void menuOpenConsoleDB_Click(object sender, EventArgs e)
        {
            ofdConsoleDB.Title = "Select Zipped Daily Directory or Console Database";
            ofdConsoleDB.Filter = "Zipped Daily Directory (.zip)|*.zip|Console Database (.mdb)|*.mdb|All (*.mdb *.zip)|*.mdb *.zip";

            //ofdConsoleDB.InitialDirectory = "c:\\";
            //ofdConsoleDB.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdConsoleDB.FilterIndex = 2;
            ofdConsoleDB.RestoreDirectory = true;
            ofdConsoleDB.FileName = "5-F-202403125707" + Program.StateRTOCode + "-DAPARA-000.mdb";

            if (ofdConsoleDB.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = ofdConsoleDB.FileName;
                    //MessageBox.Show(filePath);
                    if (!string.IsNullOrEmpty(filePath))
                    {//Microsoft.ACE.OLEDB.12.0, Microsoft.Jet.OleDb.4.0
                        connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + "; Jet OLEDB:Database Password=c0N50l3;");
                        //connect = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + filePath);
                        connect.Open();
                        if (proCheckAndCreateCSVMainTable())
                        {
                            //0 as vdfRecordNumber, SeqNum
                            //string sqlQuery = "INSERT INTO csvMain SELECT ((SELECT Count(A.Data_ID) FROM Upstream_Data_Table A WHERE A.Data_ID<= Upstream_Data_Table.Data_ID ) + (SELECT COUNT(vdfRecordNumber) FROM csvMain)) as vdfRecordNumber, Upstream_Data_Table.Data_ID as Data_ID, Upstream_Data_Table.JobNum as vdfUnit, Upstream_Data_Table.Time as vdfDateTime, Upstream_Data_Table.Time as vdfTime, CStr('N') as vdfRecordStatus, Switch (Upstream_Data_Table.Valid_Record = true , 'V', Upstream_Data_Table.Valid_Record = false , 'x' ) as vdfValid, Upstream_Data_Table.Speed as samSpeed, Upstream_Data_Table.Accel as samAccel, 'x' as samFlag, Upstream_Data_Table.CO as perCO, Upstream_Data_Table.CO2 as perCO2, Upstream_Data_Table.HC as ppmHC, Upstream_Data_Table.NOx as ppmNO, Upstream_Data_Table.SMK as uvSmoke, 0 as COCO2, 0 as HCCO2, 0 as NOCO2, 0 as maxCO2, 0 as avgCO2, 0 as samples, 0 as vdfTempAlarms, 0 as vdfAmbientAlarms, 0 as vdfMiscAlarms, '7' as pcVersion, '7' as sdmVersion, 0 as calfactorCO, 0 as calfactorCO2, 0 as calfactorHC, 0 as calfactorNO, Upstream_Data_Table.Cal_Time as calDate, Upstream_Data_Table.Cal_Time as calTime, Upstream_Data_Table.LPN as V_PLATE, '--' as V_PLATE_1, 'WB' as V_STATE_1, Upstream_Data_Table.Temp as temp, Upstream_Data_Table.Press as baro, ColorImage, UserName, SiteCode FROM Upstream_Data_Table LEFT OUTER JOIN JobInfo ON JobInfo.JobNum = Upstream_Data_Table.JobNum WHERE Upstream_Data_Table.Data_ID NOT IN (SELECT Data_ID FROM csvMain) Order by Upstream_Data_Table.Time ASC;";
                            //string sqlQuery = "INSERT INTO csvMain SELECT SeqNum as vdfRecordNumber, Upstream_Data_Table.Data_ID as Data_ID, Upstream_Data_Table.JobNum as vdfUnit, Upstream_Data_Table.Time as vdfDateTime, Upstream_Data_Table.Time as vdfTime, CStr('N') as vdfRecordStatus, Switch (Upstream_Data_Table.Valid_Gas = true , 'V', Upstream_Data_Table.Valid_Gas = false , 'x' ) as vdfValid, Upstream_Data_Table.Speed as samSpeed, Upstream_Data_Table.Accel as samAccel, 'x' as samFlag, Upstream_Data_Table.CO as perCO, Upstream_Data_Table.CO2 as perCO2, Upstream_Data_Table.HC as ppmHC, Upstream_Data_Table.NO as ppmNO, Upstream_Data_Table.SF as uvSmoke, 0 as COCO2, 0 as HCCO2, 0 as NOCO2, 0 as maxCO2, 0 as avgCO2, 0 as samples, 0 as vdfTempAlarms, 0 as vdfAmbientAlarms, 0 as vdfMiscAlarms, '7' as pcVersion, '7' as sdmVersion, 0 as calfactorCO, 0 as calfactorCO2, 0 as calfactorHC, 0 as calfactorNO, Upstream_Data_Table.Cal_Time as calDate, Upstream_Data_Table.Cal_Time as calTime, Upstream_Data_Table.LPN as V_PLATE, '--' as V_PLATE_1, 'WB' as V_STATE_1, Upstream_Data_Table.Temp as temp, Upstream_Data_Table.Press as baro, ColorImage, UserName, SiteCode FROM Upstream_Data_Table LEFT OUTER JOIN JobInfo ON JobInfo.JobNum = Upstream_Data_Table.JobNum WHERE Upstream_Data_Table.Valid_Gas = true AND Upstream_Data_Table.Data_ID NOT IN (SELECT Data_ID FROM csvMain) Order by Upstream_Data_Table.Time ASC;";
                            string sqlQuery = "INSERT INTO csvMain SELECT VDRMain.VDRMainID AS vdfRecordNumber, VDRMain.VDRMainID AS Data_ID, '______'+SDMID AS vdfUnit, FORMAT(CDATE(MID(VDRMain.VDRDateTime,1,10)),'yyyy-MM-dd') AS vdfDateTime, FORMAT(CDATE(VDRMain.VDRDateTime),'HH:mm:ss') AS vdfTime, VDRMain.VDRStatus AS vdfRecordStatus, VDRMain.VDRStatus AS vdfValid, SpeedAccel.Speed AS samSpeed, SpeedAccel.Accel AS samAccel, GasMain.Quality AS samFlag, GasMain.Percent_CO AS perCO, GasMain.Percent_CO2 AS perCO2, GasMain.PPM_HC AS ppmHC, GasMain.PPM_NO AS ppmNO, GasMain.PPM_NO2 AS ppmNO2, GasMain.PPM_NH3 AS ppmNH3, GasMain.IR_Smoke AS irSmoke, GasMain.UV_SmokeKFactor AS uvSmoke, 0 AS COCO2, 0 AS HCCO2, 0 AS NOCO2, 0 AS maxCO2, 0 AS avgCO2, 0 AS samples, 0 AS vdfTempAlarms, 0 AS vdfAmbientAlarms, 0 AS vdfMiscAlarms, 7 AS pcVersion, 7 AS sdmVersion, 0 AS calfactorCO, 0 AS calfactorCO2, 0 AS calfactorHC, 0 AS calfactorNO, CalibrationMain.CalDateTime AS calDate, CalibrationMain.CalDateTime AS calTime, License.Plate1 AS V_PLATE, '--' AS V_PLATE_1, '" + Program.StateRTOCode + "' AS V_STATE_1, GasMain.SDMTemperature AS temp, GasMain.BarometricPressure AS baro, VDRMain.STDImageName AS ColorImage, OperatorMain.FirstName AS UserName, Site.Code AS SiteCode FROM ((((((VDRMain INNER JOIN GasMain ON VDRMain.VDRMainID = GasMain.VDRMainID) INNER JOIN [Session] ON VDRMain.SessionID = Session.SessionID) INNER JOIN Site ON Session.SiteID = Site.SiteID) INNER JOIN OperatorMain ON Session.OperatorMainID = OperatorMain.OperatorMainID) INNER JOIN CalibrationMain ON VDRMain.CalibrationMainID = CalibrationMain.CalibrationMainID) INNER JOIN SpeedAccel ON VDRMain.VDRMainID = SpeedAccel.VDRMainID) LEFT JOIN License ON VDRMain.VDRMainID = License.VDRMainID WHERE (((GasMain.Quality) In ('G','M'))) AND VDRMain.VDRMainID NOT IN (SELECT vdfRecordNumber FROM csvMain) Order by VDRMain.VDRMainID ASC;";

                            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);

                            DataTable dtTable = new DataTable();
                            da.Fill(dtTable);
                            getUneditedRecord();
                            getRecord(false);
                            DBName = "Console";
                            Program.blnDatabase = true;
                            menuOpenConsoleDB.Enabled = false;
                            menuExportCSVDatabase.Enabled = true;
                            menuExportCSVNOtice.Enabled = true;
                            menuCloseDatabase.Enabled = true;
                            btnVDFAccept_Click(sender, e);
                        }
                        else
                        {
                            Program.blnDatabase = false;
                            grpSiteData.Visible = false;
                            grpRecord.Visible = false;
                            grpVDF.Visible = false;
                            menuOpenConsoleDB.Enabled = true;
                            menuExportCSVDatabase.Enabled = false;
                            menuExportCSVNOtice.Enabled = false;
                            menuCloseDatabase.Enabled = false;
                            MessageBox.Show("Error");
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        #endregion

        #region Procedures

        private void UpdateRecord()
        {
            DataTable dtTable = new DataTable();
            string sqlQuery = "SELECT * FROM csvMain WHERE vdfValid = 'V' Order by vdfRecordNumber ASC;";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);
            da.Fill(dtTable);
            if (dtTable != null)
            {
                if (dtTable.Rows[0]["vdfRecordNumber"] != DBNull.Value)
                {
                    if (tbxVDFPlate.Text.Trim() == "--" || tbxVDFPlate.Text.Trim() == "NR")
                    {
                        cbxVehCatCode.Text = "NA";
                        cbxVehTypeCode.Text = "NA";
                        cbxVehPlateCode.Text = "NA";
                        cbxVehMfgCode.Text = "NA";
                    }

                    string vdfRecNo = Convert.ToString(dtTable.Rows[cntRecordNo]["vdfRecordNumber"]);
                    string strQry = "UPDATE csvMain SET V_PLATE_1 = '" + tbxVDFPlate.Text.Trim() + "', V_STATE_1 = '" + tbxState.Text.Trim() + "', VehCatCode = '" + cbxVehCatCode.Text.Trim() + "', VehTypeCode = '" + cbxVehTypeCode.Text.Trim() + "', VehPlateCode = '" + cbxVehPlateCode.Text.Trim() + "', VehMfgCode = '" + cbxVehMfgCode.Text.Trim() + "' WHERE vdfRecordNumber = " + vdfRecNo + ";";
                    OleDbCommand myCommand = new OleDbCommand();
                    myCommand.Connection = connect;
                    myCommand.CommandText = strQry;
                    if (myCommand.Connection.State != ConnectionState.Open) myCommand.Connection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    if (cntRecordNo >= dtTable.Rows.Count)
                    { cntRecordNo = dtTable.Rows.Count - 1; }
                    lblVDFUneditedRecords.Text = dtTable.Rows.Count.ToString() + " Unedited Records";
                }
            }
            tbxVDFPlate.Focus();
        }
        private void getUneditedRecord()
        {
            DataTable dtTable = new DataTable();
            string sqlQuery = "SELECT * FROM csvMain WHERE V_PLATE_1 = '--' AND vdfValid = 'V' Order by vdfRecordNumber ASC;";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);
            da.Fill(dtTable);
            lblVDFUneditedRecords.Text = dtTable.Rows.Count.ToString() + " Unedited Records";
        }
        private void ImageCopyIntoPicsFolder(string SeqNum, string sourceFilePath, string destFilePath)
        {
            string sResult = string.Empty;
            DataTable dtTable = new DataTable();
            string sqlQuery = "SELECT Upstream_Data_Table.JobNum, Scope_Table.Scope, Scope_Table.ScopeName, Upstream_Data_Table.ColorImage, Mid([Time],7,4)+Mid([Time],4,2)+Mid([Time],1,2)+Mid([JobNum],7,4)+'" + Program.StateRTOCode + "'+Mid([JobNum],1,4)+CStr(Format([SeqNum],'00000'))+'.jpg' AS Pics, Upstream_Data_Table.Data_ID\r\nFROM Upstream_Data_Table INNER JOIN Scope_Table ON Upstream_Data_Table.ScopeTableID = Scope_Table.ScopeTableID WHERE Upstream_Data_Table.SeqNum = " + SeqNum + ";";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);
            da.Fill(dtTable);
            if (dtTable != null)
            {
                if (dtTable.Rows.Count >= 0)
                {
                    string srcFilePath = sourceFilePath + dtTable.Rows[0]["ColorImage"].ToString().Replace("/", "\\");
                    srcFilePath = srcFilePath.Replace("\\\\", "\\");
                    string desFilePath = destFilePath + dtTable.Rows[0]["Pics"].ToString();
                    desFilePath = desFilePath.Replace("\\\\", "\\");
                    //desFilePath = Application.StartupPath  + dtTable.Rows[0]["Pics"].ToString();
                    //Image img = Image.FromFile(srcFilePath);
                    //img.Save(destFilePath);


                    File.Copy(srcFilePath, desFilePath, true);
                }
            }
            //return sResult;
        }
        private void getRecord(bool bGotoVDF)
        {
            DataTable dtTable = new DataTable();
            string sqlQuery = "SELECT * FROM csvMain WHERE vdfValid = 'V' Order by vdfRecordNumber ASC;";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);
            da.Fill(dtTable);

            if (dtTable != null)
            {
                //DataRow[] drUnedited = dtTable.Select("V_PLATE_1 = '--'");
                //lblVDFUneditedRecords.Text = drUnedited.Length.ToString() + " Unedited Records";

                //for (int i = 0; i < drUnedited.Length; i++)
                //{
                //    if (dtTable.Rows[i]["V_PLATE_1"].ToString() == "--")
                //    {
                //        cntRecordNo = i;
                //        break;
                //    }
                //}
                if (!bGotoVDF)
                {
                    for (int i = 0; i < dtTable.Rows.Count; i++)
                    {
                        if (dtTable.Rows[i]["V_PLATE_1"].ToString() == "--")
                        {
                            cntRecordNo = i;
                            break;
                        }
                    }
                }
                if (dtTable.Rows.Count > 0)
                {
                Top:
                    cntTotalRecords = dtTable.Rows.Count;
                    if (cntRecordNo >= cntTotalRecords)
                    { cntRecordNo = cntTotalRecords - 1; }
                    //if (cntRecordNo == 0) cntRecordNo++;
                    tbxOptionsGoToVDF.Text = (cntRecordNo + 1).ToString();
                    lblVDFNoofRecords.Text = "Record " + (cntRecordNo + 1).ToString() + " of " + cntTotalRecords.ToString();

                    string imgPath = filePath.Substring(0, filePath.IndexOf(ofdConsoleDB.SafeFileName)) + "Pics\\" + dtTable.Rows[cntRecordNo]["ColorImage"].ToString();
                    imgPath = imgPath.Replace("/", "\\");
                    if (File.Exists(imgPath))
                    {
                        pbxImage.Image = Image.FromFile(imgPath);

                        lblNoDatabaseLoaded.Visible = false;
                        lblSelectDatabasefromfilemenu.Visible = false;

                        tbxRecordTime.Text = dtTable.Rows[cntRecordNo]["vdfTime"].ToString();
                        tbxRecordCVAStatus.Text = dtTable.Rows[cntRecordNo]["vdfValid"].ToString();
                        tbxRecordSpeed.Text = dtTable.Rows[cntRecordNo]["samSpeed"].ToString();
                        tbxRecordAccel.Text = dtTable.Rows[cntRecordNo]["samAccel"].ToString();
                        //tbxRecordVSP.Text = dtTable.Rows[cntRecordNo]["VSP"].ToString();
                        tbxRecordPerCO.Text = dtTable.Rows[cntRecordNo]["PerCO"].ToString();
                        tbxRecordPerCO2.Text = dtTable.Rows[cntRecordNo]["PerCO2"].ToString();
                        tbxRecordHCppm.Text = dtTable.Rows[cntRecordNo]["ppmHC"].ToString();
                        tbxRecordNOppm.Text = dtTable.Rows[cntRecordNo]["ppmNO"].ToString();
                        tbxRecordCO2max.Text = dtTable.Rows[cntRecordNo]["maxCO2"].ToString();
                        tbxRecorduvSmoke.Text = dtTable.Rows[cntRecordNo]["uvSmoke"].ToString();

                        tbxRecordirSmoke.Text = dtTable.Rows[cntRecordNo]["irSmoke"].ToString();
                        tbxRecordNO2ppm.Text = dtTable.Rows[cntRecordNo]["ppmNO2"].ToString();
                        tbxRecordNH3ppm.Text = dtTable.Rows[cntRecordNo]["ppmNH3"].ToString();

                        tbxSiteDataSiteCode.Text = dtTable.Rows[cntRecordNo]["SiteCode"].ToString();
                        tbxSiteDataOperator.Text = dtTable.Rows[cntRecordNo]["UserName"].ToString();
                        tbxSiteDataSlope.Text = string.Empty;

                        tbxVDFPlate.Text = dtTable.Rows[cntRecordNo]["V_PLATE_1"].ToString();
                        tbxState.Text = dtTable.Rows[cntRecordNo]["V_STATE_1"].ToString();

                        cbxVehCatCode.Text = dtTable.Rows[cntRecordNo]["VehCatCode"].ToString();
                        cbxVehTypeCode.Text = dtTable.Rows[cntRecordNo]["VehTypeCode"].ToString();
                        cbxVehPlateCode.Text = dtTable.Rows[cntRecordNo]["VehPlateCode"].ToString();
                        cbxVehMfgCode.Text = dtTable.Rows[cntRecordNo]["VehMfgCode"].ToString();

                        grpSiteData.Visible = true;
                        grpRecord.Visible = true;
                        grpVDF.Visible = true;
                    }
                    else
                    {
                        string vdfRecNo = Convert.ToString(dtTable.Rows[cntRecordNo]["vdfRecordNumber"]);
                        string strQry = "UPDATE csvMain SET V_PLATE_1 = 'NA', V_STATE_1 = '" + tbxState.Text.Trim() + "' WHERE vdfRecordNumber = " + vdfRecNo + ";";
                        OleDbCommand myCommand = new OleDbCommand();
                        myCommand.Connection = connect;
                        myCommand.CommandText = strQry;
                        if (myCommand.Connection.State != ConnectionState.Open) myCommand.Connection.Open();
                        myCommand.ExecuteNonQuery();
                        myCommand.Connection.Close();
                        cntRecordNo += 1;
                        goto Top;
                    }
                }
            }
        }
        private void DisplayActiveFilters(string para)
        {
            lblActiveFilters.Text = para;

            if (para == "CleanScreen")
            {
                tbxActiveFiltersSnA.Text = "S/A";
                tbxActiveFiltersGas.Text = "Gas";
                tbxActiveFiltersCVA.Text = "CVA";
                tbxActiveFiltersVSP.Text = "VSP";
                tbxActiveFiltersSpeed.Text = "Speed";
                tbxActiveFiltersAccel.Text = "Accel";
                tbxActiveFiltersALPR.Text = "ALPR";
                tbxActiveFiltersCleanScreen.Text = "Clean Screen";

                tbxActiveFiltersSnA.BackColor = Color.LimeGreen;
                tbxActiveFiltersGas.BackColor = Color.LimeGreen;
                tbxActiveFiltersCVA.BackColor = Color.LimeGreen;
                tbxActiveFiltersVSP.BackColor = Color.LimeGreen;
                tbxActiveFiltersSpeed.BackColor = Color.White;
                tbxActiveFiltersAccel.BackColor = Color.White;
                tbxActiveFiltersALPR.BackColor = Color.White;
                tbxActiveFiltersCleanScreen.BackColor = Color.LimeGreen;

            }
            else if (para == "Filter All")
            {
                tbxActiveFiltersSnA.Text = "S/A";
                tbxActiveFiltersGas.Text = "Gas";
                tbxActiveFiltersCVA.Text = "CVA";
                tbxActiveFiltersVSP.Text = "VSP";
                tbxActiveFiltersSpeed.Text = "Speed";
                tbxActiveFiltersAccel.Text = "Accel";
                tbxActiveFiltersALPR.Text = "ALPR";
                tbxActiveFiltersCleanScreen.Text = string.Empty;

                tbxActiveFiltersSnA.BackColor = Color.LimeGreen;
                tbxActiveFiltersGas.BackColor = Color.LimeGreen;
                tbxActiveFiltersCVA.BackColor = Color.LimeGreen;
                tbxActiveFiltersVSP.BackColor = Color.LimeGreen;
                tbxActiveFiltersSpeed.BackColor = Color.LimeGreen;
                tbxActiveFiltersAccel.BackColor = Color.LimeGreen;
                tbxActiveFiltersALPR.BackColor = Color.LimeGreen;
                tbxActiveFiltersCleanScreen.BackColor = Color.White;
            }
            else if (para == "Gross Emitter")
            {
                tbxActiveFiltersSnA.Text = "S/A";
                tbxActiveFiltersGas.Text = "Gas";
                tbxActiveFiltersCVA.Text = "CVA";
                tbxActiveFiltersVSP.Text = "VSP";
                tbxActiveFiltersSpeed.Text = "Speed";
                tbxActiveFiltersAccel.Text = "Accel";
                tbxActiveFiltersALPR.Text = "ALPR";
                tbxActiveFiltersCleanScreen.Text = "Gross Emitter";

                tbxActiveFiltersSnA.BackColor = Color.LimeGreen;
                tbxActiveFiltersGas.BackColor = Color.LimeGreen;
                tbxActiveFiltersCVA.BackColor = Color.LimeGreen;
                tbxActiveFiltersVSP.BackColor = Color.White;
                tbxActiveFiltersSpeed.BackColor = Color.LimeGreen;
                tbxActiveFiltersAccel.BackColor = Color.LimeGreen;
                tbxActiveFiltersALPR.BackColor = Color.LimeGreen;
                tbxActiveFiltersCleanScreen.BackColor = Color.LimeGreen;
            }
            else if (para == "OHIO")
            {
                tbxActiveFiltersSnA.Text = "S/A";
                tbxActiveFiltersGas.Text = "Gas";
                tbxActiveFiltersCVA.Text = "CVA";
                tbxActiveFiltersVSP.Text = "VSP";
                tbxActiveFiltersSpeed.Text = "Speed";
                tbxActiveFiltersAccel.Text = "Accel";
                tbxActiveFiltersALPR.Text = "ALPR";
                tbxActiveFiltersCleanScreen.Text = string.Empty;

                tbxActiveFiltersSnA.BackColor = Color.LimeGreen;
                tbxActiveFiltersGas.BackColor = Color.LimeGreen;
                tbxActiveFiltersCVA.BackColor = Color.White;
                tbxActiveFiltersVSP.BackColor = Color.White;
                tbxActiveFiltersSpeed.BackColor = Color.White;
                tbxActiveFiltersAccel.BackColor = Color.White;
                tbxActiveFiltersALPR.BackColor = Color.White;
                tbxActiveFiltersCleanScreen.BackColor = Color.White;
            }
            else if (para == "Show All")
            {
                tbxActiveFiltersSnA.Text = "S/A";
                tbxActiveFiltersGas.Text = "Gas";
                tbxActiveFiltersCVA.Text = "CVA";
                tbxActiveFiltersVSP.Text = "VSP";
                tbxActiveFiltersSpeed.Text = "Speed";
                tbxActiveFiltersAccel.Text = "Accel";
                tbxActiveFiltersALPR.Text = "ALPR";
                tbxActiveFiltersCleanScreen.Text = string.Empty;

                tbxActiveFiltersSnA.BackColor = Color.White;
                tbxActiveFiltersGas.BackColor = Color.White;
                tbxActiveFiltersCVA.BackColor = Color.White;
                tbxActiveFiltersVSP.BackColor = Color.White;
                tbxActiveFiltersSpeed.BackColor = Color.White;
                tbxActiveFiltersAccel.BackColor = Color.White;
                tbxActiveFiltersALPR.BackColor = Color.White;
                tbxActiveFiltersCleanScreen.BackColor = Color.White;
            }
        }
        private void CheckStateUpdate(string para)
        {
            menuCleanScreen.CheckState = CheckState.Unchecked;
            menuFilterAll.CheckState = CheckState.Unchecked;
            menuGrossEmitter.CheckState = CheckState.Unchecked;
            menuOHIO.CheckState = CheckState.Unchecked;
            menuShowAll.CheckState = CheckState.Unchecked;

            if (para == "CleanScreen")
            {
                menuCleanScreen.CheckState = CheckState.Checked;
            }
            else if (para == "Filter All")
            {
                menuFilterAll.CheckState = CheckState.Checked;
            }
            else if (para == "Gross Emitter")
            {
                menuGrossEmitter.CheckState = CheckState.Checked;
            }
            else if (para == "OHIO")
            {
                menuOHIO.CheckState = CheckState.Checked;
            }
            else if (para == "Show All")
            {
                menuShowAll.CheckState = CheckState.Checked;
            }


        }

        #endregion

        #region Functions 

        private bool proCheckAndCreateCSVMainTable()
        {

            //string strCheck = "select MSysObjects.name from MSysObjects where MSysObjects.type In (1,4,6) and MSysObjects.name = 'csvMain'";
            //OleDbDataAdapter da = new OleDbDataAdapter(strCheck, connect);

            DataTable dtTable = new DataTable();
            //da.Fill(dtTable);

            dtTable = connect.GetSchema("tables");
            DataRow[] drr = dtTable.Select("TABLE_NAME = 'csvMain'");

            if (drr.Length <= 0)
            {
                try
                {
                    string strQry = "CREATE TABLE csvMain (vdfRecordNumber Number, Data_ID VARCHAR, vdfUnit VARCHAR, vdfDateTime VARCHAR(30), vdfTime VARCHAR(30), vdfRecordStatus VARCHAR, vdfValid VARCHAR, samSpeed REAL, samAccel REAL, samFlag VARCHAR, perCO REAL, perCO2 REAL, ppmHC REAL, ppmNO REAL, ppmNO2 REAL, ppmNH3 REAL, irSmoke REAL, uvSmoke REAL, COCO2 REAL, HCCO2 REAL, NOCO2 REAL,  maxCO2 REAL, avgCO2 REAL, samples REAL, vdfTempAlarms REAL, vdfAmbientAlarms REAL, vdfMiscAlarms REAL, pcVersion VARCHAR, sdmVersion VARCHAR, calfactorCO REAL, calfactorCO2 REAL, calfactorHC REAL, calfactorNO REAL, calDate VARCHAR(30), calTime VARCHAR(30), V_PLATE VARCHAR(20), V_PLATE_1 VARCHAR(20), V_STATE_1 VARCHAR(2), temp INTEGER, baro INTEGER, ColorImage VARCHAR(255), UserName VARCHAR(50), SiteCode VARCHAR(20), VehCatCode VARCHAR(20), VehTypeCode VARCHAR(20), VehPlateCode VARCHAR(20), VehMfgCode VARCHAR(30), CONSTRAINT PrimaryKey PRIMARY KEY (vdfRecordNumber));";
                    OleDbCommand myCommand = new OleDbCommand();
                    myCommand.Connection = connect;
                    myCommand.CommandText = strQry;
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    return true;
                }
                catch (OleDbException e)
                {
                    if (e.Message == "Table 'csvMain' already exists.")
                    { return true; }
                    else
                        return false;
                }
            }
            return true;
        }
        private DataTable getExportData()
        {
            DataTable dtTable = new DataTable();
            //string sqlQuery = "SELECT vdfRecordNumber, vdfUnit, vdfDateTime, vdfTime, vdfRecordStatus, vdfValid, samSpeed, samAccel, samFlag, perCO, perCO2, ppmHC, ppmNO, uvSmoke, COCO2, HCCO2, NOCO2, maxCO2, avgCO2, samples, vdfTempAlarms, vdfAmbientAlarms, vdfMiscAlarms, pcVersion, sdmVersion, calfactorCO, calfactorCO2, calfactorHC, calfactorNO, calDate, calTime, V_PLATE, V_PLATE_1, V_STATE_1, temp, baro\r\n FROM csvMain WHERE V_PLATE_1 <> '--' Order by vdfRecordNumber ASC;";
            //string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, Mid([vdfDateTime],7,4)+'-'+Mid([vdfDateTime],1,2)+'-'+Mid([vdfDateTime],4,2) AS vdfDateTime1, Mid([vdfTime],12,8) AS vdfTime1, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, Mid([csvMain.calDate],7,4)+'-'+Mid([csvMain.calDate],1,2)+'-'+Mid([csvMain.calDate],4,2) AS calDate1, Mid([csvMain.calTime],12,8) AS calTime1,csvMain.V_PLATE, csvMain.V_PLATE_1, csvMain.V_STATE_1, csvMain.temp, csvMain.baro\r\nFROM csvMain\r\nWHERE (((csvMain.V_PLATE_1)<>'--'))\r\nORDER BY csvMain.vdfRecordNumber;\r\n";
            //string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, Mid([vdfDateTime],1,instr(csvMain.vdfDateTime,' ')-1) AS vdfDateTime1, Mid([vdfTime],instr(csvMain.vdfDateTime,' '),instr(csvMain.vdfDateTime,'m')) AS vdfTime1, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, '1900-01-01' AS calDate1, '00:00:00' AS calTime1,csvMain.V_PLATE_1 AS V_PLATE, '--' AS V_PLATE_1, csvMain.V_STATE_1, csvMain.temp, csvMain.baro\r\nFROM csvMain\r\nWHERE (((csvMain.V_PLATE_1)<>'--')) AND (((csvMain.V_PLATE_1)<>'NA')) AND vdfValid = 'V' \r\nORDER BY csvMain.vdfRecordNumber;\r\n";
            //string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, vdfDateTime, vdfTime, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.ppmNO2, csvMain.ppmNH3, csvMain.irSmoke, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, '1900-01-01' AS calDate1, '00:00:00' AS calTime1,csvMain.V_PLATE_1 AS V_PLATE, '--' AS V_PLATE_1, VehCatCode, VehTypeCode, VehPlateCode, csvMain.V_STATE_1, csvMain.temp, csvMain.baro\r\nFROM csvMain\r\nWHERE (((csvMain.V_PLATE_1)<>'--')) AND (((csvMain.V_PLATE_1)<>'NA')) AND vdfValid = 'V' \r\nORDER BY csvMain.vdfRecordNumber;\r\n";

            string sqlQuery = @"SELECT
                    csvMain.vdfRecordNumber,
                    csvMain.vdfUnit,
                    vdfDateTime,
                    vdfTime,
                    csvMain.vdfRecordStatus,
                    csvMain.vdfValid,
                    csvMain.samSpeed,
                    csvMain.samAccel,
                    csvMain.samFlag,
                    csvMain.perCO,
                    csvMain.perCO2,
                    csvMain.ppmHC,
                    csvMain.ppmNO,
                    csvMain.ppmNO2,
                    csvMain.ppmNH3,
                    csvMain.irSmoke,
                    csvMain.uvSmoke,
                    csvMain.COCO2,
                    csvMain.HCCO2,
                    csvMain.NOCO2,
                    csvMain.maxCO2,
                    csvMain.avgCO2,
                    csvMain.samples,
                    csvMain.vdfTempAlarms,
                    csvMain.vdfAmbientAlarms,
                    csvMain.vdfMiscAlarms,
                    csvMain.pcVersion,
                    csvMain.sdmVersion,
                    csvMain.calfactorCO,
                    csvMain.calfactorCO2,
                    csvMain.calfactorHC,
                    csvMain.calfactorNO,
                    '1900-01-01' AS calDate1,
                    '00:00:00' AS calTime1,
                    csvMain.V_PLATE_1 AS V_PLATE,
                    '--' AS V_PLATE_1,
                    VehCatCode,
                    VehTypeCode,
                    VehPlateCode,
                    VehMfgCode,
                    csvMain.V_STATE_1,
                    csvMain.temp,
                    csvMain.baro,
                    VDRMainID,
                    NumberOfPlumePoints,
                    FirstPlumePointNumber,
                    ProcessBitMask,
                    ValidPlumePoints,
                    PPM_UHC,
                    PPM_USM,
                    PPM_UWA,
                    PeakOpacity_UV,
                    PeakOpacity_IR,
                    UV_SmokeKFactor,
                    IR_SmokeKFactor,
                    Slope_A_CO,
                    SlopeError_A_CO,
                    Slope_B_CO,
                    SlopeError_B_CO,
                    Intercept_B_CO,
                    InterceptError_B_CO,
                    FinalSlope_CO,
                    FinalSlopeError_CO,
                    Method_CO,
                    ValidPlumePoints_CO,
                    CalcError_A_CO,
                    CalcError_B_CO,
                    LLR_CO,
                    SlopeTolError_CO,
                    ValidationMask_CO,
                    Flag_CO,
                    Slope_A_HC,
                    SlopeError_A_HC,
                    Slope_B_HC,
                    SlopeError_B_HC,
                    Intercept_B_HC,
                    InterceptError_B_HC,
                    FinalSlope_HC,
                    FinalSlopeError_HC,
                    Method_HC,
                    ValidPlumePoints_HC,
                    CalcError_A_HC,
                    CalcError_B_HC,
                    LLR_HC,
                    SlopeTolError_HC,
                    ValidationMask_HC,
                    Flag_HC,
                    Slope_A_COHC,
                    SlopeError_A_COHC,
                    Slope_B_COHC,
                    SlopeError_B_COHC,
                    Intercept_B_COHC,
                    InterceptError_B_COHC,
                    FinalSlope_COHC,
                    FinalSlopeError_COHC,
                    Method_COHC,
                    ValidPlumePoints_COHC,
                    CalcError_A_COHC,
                    CalcError_B_COHC,
                    Flag_COHC,
                    Slope_A_NO,
                    SlopeError_A_NO,
                    Slope_B_NO,
                    SlopeError_B_NO,
                    Intercept_B_NO,
                    InterceptError_B_NO,
                    FinalSlope_NO,
                    FinalSlopeError_NO,
                    Method_NO,
                    ValidPlumePoints_NO,
                    CalcError_A_NO,
                    CalcError_B_NO,
                    LLR_NO,
                    SlopeTolError_NO,
                    ValidationMask_NO,
                    Flag_NO,
                    Slope_A_NO2,
                    SlopeError_A_NO2,
                    Slope_B_NO2,
                    SlopeError_B_NO2,
                    Intercept_B_NO2,
                    InterceptError_B_NO2,
                    FinalSlope_NO2,
                    FinalSlopeError_NO2,
                    Method_NO2,
                    ValidPlumePoints_NO2,
                    CalcError_A_NO2,
                    CalcError_B_NO2,
                    LLR_NO2,
                    SlopeTolError_NO2,
                    ValidationMask_NO2,
                    Flag_NO2,
                    Slope_A_NH3,
                    SlopeError_A_NH3,
                    Slope_B_NH3,
                    SlopeError_B_NH3,
                    Intercept_B_NH3,
                    InterceptError_B_NH3,
                    FinalSlope_NH3,
                    FinalSlopeError_NH3,
                    Method_NH3,
                    ValidPlumePoints_NH3,
                    CalcError_A_NH3,
                    CalcError_B_NH3,
                    LLR_NH3,
                    SlopeTolError_NH3,
                    ValidationMask_NH3,
                    Flag_NH3,
                    Slope_A_UHC,
                    SlopeError_A_UHC,
                    Slope_B_UHC,
                    SlopeError_B_UHC,
                    Intercept_B_UHC,
                    InterceptError_B_UHC,
                    FinalSlope_UHC,
                    FinalSlopeError_UHC,
                    Method_UHC,
                    ValidPlumePoints_UHC,
                    CalcError_A_UHC,
                    CalcError_B_UHC,
                    Flag_UHC,
                    Slope_A_USM,
                    SlopeError_A_USM,
                    Slope_B_USM,
                    SlopeError_B_USM,
                    Intercept_B_USM,
                    InterceptError_B_USM,
                    FinalSlope_USM,
                    FinalSlopeError_USM,
                    Method_USM,
                    ValidPlumePoints_USM,
                    CalcError_A_USM,
                    CalcError_B_USM,
                    Flag_USM,
                    Slope_A_UWA,
                    SlopeError_A_UWA,
                    Slope_B_UWA,
                    SlopeError_B_UWA,
                    Intercept_B_UWA,
                    InterceptError_B_UWA,
                    FinalSlope_UWA,
                    FinalSlopeError_UWA,
                    Method_UWA,
                    ValidPlumePoints_UWA,
                    CalcError_A_UWA,
                    CalcError_B_UWA,
                    Flag_UWA,
                    Slope_B_IRSmoke,
                    SlopeError_B_IRSmoke,
                    Intercept_B_IRSmoke,
                    InterceptError_B_IRSmoke,
                    Method_IRSmoke,
                    ValidPlumePoints_IRSmoke,
                    CalcError_B_IRSmoke,
                    Flag_IRSmoke,
                    Slope_B_UVSmoke,
                    SlopeError_B_UVSmoke,
                    Intercept_B_UVSmoke,
                    InterceptError_B_UVSmoke,
                    Method_UVSmoke,
                    ValidPlumePoints_UVSmoke,
                    CalcError_B_UVSmoke,
                    Flag_UVSmoke,
                    Ratio_CO_CO2,
                    Ratio_HC_CO2,
                    Ratio_CO_HC,
                    Ratio_NO_CO2,
                    Ratio_NO2_CO2,
                    Ratio_NH3_CO2,
                    Ratio_UHC_CO2,
                    Ratio_USM_CO2,
                    Ratio_UWA_CO2,
                    Average_CO2,
                    Max_CO2,
                    Ambient_CO,
                    Ambient_CO2,
                    Ambient_HC,
                    Ambient_NO,
                    Ambient_NO2,
                    Ambient_NH3,
                    Ambient_UHC,
                    Ambient_USM,
                    Ambient_UWA,
                    CalFactor_CO,
                    CalFactor_CO2,
                    CalFactor_HC,
                    AmbientTemperature,
                    Humidity,
                    UVPixelCutOff
                FROM csvMain
                INNER JOIN GasMain
                    ON csvMain.vdfRecordNumber = GasMain.VDRMainID
                WHERE csvMain.V_PLATE_1 <> '--'
                  AND csvMain.V_PLATE_1 <> 'NA'
                  AND vdfValid = 'V'
                ORDER BY csvMain.vdfRecordNumber;
                ";



            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);
            da.Fill(dtTable);
            dtTable.Columns["vdfDateTime"].ColumnName = "vdfDateTime";
            dtTable.Columns["vdfTime"].ColumnName = "vdfTime";
            dtTable.Columns["calDate1"].ColumnName = "calDate";
            dtTable.Columns["calTime1"].ColumnName = "calTime";
            return dtTable;
        }
        private DataTable getExportNoticeData()
        {
            DataTable dtTable = new DataTable();
            //string sqlQuery = "SELECT vdfRecordNumber, vdfUnit, vdfDateTime, vdfTime, vdfRecordStatus, vdfValid, samSpeed, samAccel, samFlag, perCO, perCO2, ppmHC, ppmNO, uvSmoke, COCO2, HCCO2, NOCO2, maxCO2, avgCO2, samples, vdfTempAlarms, vdfAmbientAlarms, vdfMiscAlarms, pcVersion, sdmVersion, calfactorCO, calfactorCO2, calfactorHC, calfactorNO, calDate, calTime, V_PLATE, V_PLATE_1, V_STATE_1, temp, baro\r\n FROM csvMain WHERE V_PLATE_1 <> '--' Order by vdfRecordNumber ASC;";
            //string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, Mid([vdfDateTime],7,4)+'-'+Mid([vdfDateTime],1,2)+'-'+Mid([vdfDateTime],4,2) AS vdfDateTime1, Mid([vdfTime],12,8) AS vdfTime1, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, Mid([csvMain.calDate],7,4)+'-'+Mid([csvMain.calDate],1,2)+'-'+Mid([csvMain.calDate],4,2) AS calDate1, Mid([csvMain.calTime],12,8) AS calTime1,csvMain.V_PLATE, csvMain.V_PLATE_1, csvMain.V_STATE_1, csvMain.temp, csvMain.baro\r\nFROM csvMain\r\nWHERE (((csvMain.V_PLATE_1)<>'--'))\r\nORDER BY csvMain.vdfRecordNumber;\r\n";
            //string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, Mid([vdfDateTime],1,instr(csvMain.vdfDateTime,' ')-1) AS vdfDateTime1, Mid([vdfTime],instr(csvMain.vdfDateTime,' '),instr(csvMain.vdfDateTime,'m')) AS vdfTime1, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, '1900-01-01' AS calDate1, '00:00:00' AS calTime1,csvMain.V_PLATE_1 AS V_PLATE, '--' AS V_PLATE_1, csvMain.V_STATE_1, csvMain.temp, csvMain.baro\r\nFROM csvMain\r\nWHERE (((csvMain.V_PLATE_1)<>'--')) AND (((csvMain.V_PLATE_1)<>'NA')) AND vdfValid = 'V' \r\nORDER BY csvMain.vdfRecordNumber;\r\n";
            //string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, vdfDateTime, vdfTime, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, '1900-01-01' AS calDate1, '00:00:00' AS calTime1,csvMain.V_PLATE_1 AS V_PLATE, '--' AS V_PLATE_1, csvMain.V_STATE_1, csvMain.temp, csvMain.baro\r\nFROM csvMain\r\nWHERE (((csvMain.V_PLATE_1)<>'--')) AND (((csvMain.V_PLATE_1)<>'NA')) AND vdfValid = 'V' \r\nORDER BY csvMain.vdfRecordNumber;\r\n";
            string sqlQuery = "SELECT csvMain.vdfRecordNumber, csvMain.vdfUnit, csvMain.vdfDateTime, csvMain.vdfTime, csvMain.vdfRecordStatus, csvMain.vdfValid, csvMain.samSpeed, csvMain.samAccel, csvMain.samFlag, csvMain.perCO, csvMain.perCO2, csvMain.ppmHC, csvMain.ppmNO, csvMain.uvSmoke, csvMain.COCO2, csvMain.HCCO2, csvMain.NOCO2, csvMain.maxCO2, csvMain.avgCO2, csvMain.samples, csvMain.vdfTempAlarms, csvMain.vdfAmbientAlarms, csvMain.vdfMiscAlarms, csvMain.pcVersion, csvMain.sdmVersion, csvMain.calfactorCO, csvMain.calfactorCO2, csvMain.calfactorHC, csvMain.calfactorNO, '1900-01-01' AS calDate1, '00:00:00' AS calTime1, csvMain.V_PLATE_1 AS V_PLATE, '--' AS V_PLATE_1, csvMain.V_STATE_1, csvMain.temp, csvMain.baro, VDRMain.STDImageName AS Pics\r\nFROM csvMain INNER JOIN VDRMain ON csvMain.vdfRecordNumber = VDRMain.VDRMainID\r\nWHERE (((csvMain.V_PLATE_1)<>'--' And (csvMain.V_PLATE_1)<>'NA') AND ((csvMain.[vdfValid])='V'))\r\nORDER BY csvMain.vdfRecordNumber;\r\n";

            OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery, connect);
            da.Fill(dtTable);
            dtTable.Columns["vdfDateTime"].ColumnName = "vdfDateTime";
            dtTable.Columns["vdfTime"].ColumnName = "vdfTime";
            dtTable.Columns["calDate1"].ColumnName = "calDate";
            dtTable.Columns["calTime1"].ColumnName = "calTime";
            return dtTable;
        }
        #endregion



    }//Class
}//Namespace

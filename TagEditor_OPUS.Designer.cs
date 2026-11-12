namespace TagEdit.Net
{
    partial class TagEditor_OPUS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpSiteData = new GroupBox();
            lblSiteDataSiteCode = new Label();
            tbxSiteDataSlope = new TextBox();
            lblSiteDataSlope = new Label();
            tbxSiteDataOperator = new TextBox();
            lblSiteDataOperator = new Label();
            tbxSiteDataSiteCode = new TextBox();
            lblRecordCO2max = new Label();
            tbxRecorduvSmoke = new TextBox();
            grpRecord = new GroupBox();
            tbxRecordNH3ppm = new TextBox();
            lblRecordNH3ppm = new Label();
            tbxRecordNO2ppm = new TextBox();
            lblRecordNO2ppm = new Label();
            tbxRecordirSmoke = new TextBox();
            lblRecordirSmoke = new Label();
            lblRecorduvSmoke = new Label();
            tbxRecordCO2max = new TextBox();
            lblRecordPerCO2 = new Label();
            tbxRecordNOppm = new TextBox();
            lblRecordNOppm = new Label();
            tbxRecordHCppm = new TextBox();
            lblRecordHCppm = new Label();
            tbxRecordPerCO2 = new TextBox();
            lblRecordAccel = new Label();
            tbxRecordPerCO = new TextBox();
            lblRecordPerCO = new Label();
            tbxRecordVSP = new TextBox();
            lblRecordVSP = new Label();
            tbxRecordAccel = new TextBox();
            lblRecordTime = new Label();
            tbxRecordSpeed = new TextBox();
            lblRecordSpeed = new Label();
            tbxRecordCVAStatus = new TextBox();
            lblRecordCVAStatus = new Label();
            tbxRecordTime = new TextBox();
            btnOptionsGoToVDF = new Button();
            tbxOptionsGoToVDF = new TextBox();
            tbxState = new TextBox();
            lblVDFPlate = new Label();
            lblShowHotKeys = new Label();
            lblVDFUneditedRecords = new Label();
            lblVDFNoofRecords = new Label();
            tbxVDFPlate = new TextBox();
            btnVDFAccept = new Button();
            lblZoomIn = new Label();
            lblZoomOut = new Label();
            tmrTimer = new System.Windows.Forms.Timer(components);
            grpVDF = new GroupBox();
            cbxVehMfgCode = new ComboBox();
            cbxVehPlateCode = new ComboBox();
            cbxVehTypeCode = new ComboBox();
            cbxVehCatCode = new ComboBox();
            lblVehPlateCode = new Label();
            lblVehTypeCode = new Label();
            lblVehCatCode = new Label();
            lblSelectDatabasefromfilemenu = new Label();
            ofdConsoleDB = new OpenFileDialog();
            lblNoDatabaseLoaded = new Label();
            menuCleanScreen = new ToolStripMenuItem();
            menuConfiguration = new ToolStripMenuItem();
            menuFilterAll = new ToolStripMenuItem();
            menuGrossEmitter = new ToolStripMenuItem();
            menuOHIO = new ToolStripMenuItem();
            menuShowAll = new ToolStripMenuItem();
            menuSPConfiguration1 = new ToolStripSeparator();
            menuEditConfigurations = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuSPFile3 = new ToolStripSeparator();
            menuCloseDatabase = new ToolStripMenuItem();
            menuExportCSVDatabase = new ToolStripMenuItem();
            menuSPFile2 = new ToolStripSeparator();
            menuOpenVIDDB = new ToolStripMenuItem();
            menuOpenConsoleDB = new ToolStripMenuItem();
            menuOpenLiveDB = new ToolStripMenuItem();
            menuSPFile1 = new ToolStripSeparator();
            menuLogin = new ToolStripMenuItem();
            menuFile = new ToolStripMenuItem();
            menuExportCSVNOtice = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuHelp = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            tbxTagEditTime = new TextBox();
            lblTagEditTime = new Label();
            tbxTagEditDate = new TextBox();
            lblTagEditDate = new Label();
            tbxTagEditUser = new TextBox();
            grpTagEditor = new GroupBox();
            pbxImage = new PictureBox();
            lblActiveFilters = new Label();
            tbxActiveFiltersCleanScreen = new TextBox();
            tbxActiveFiltersALPR = new TextBox();
            tbxActiveFiltersAccel = new TextBox();
            tbxActiveFiltersSpeed = new TextBox();
            tbxActiveFiltersVSP = new TextBox();
            tbxActiveFiltersCVA = new TextBox();
            grpActiveFilters = new GroupBox();
            tbxActiveFiltersGas = new TextBox();
            tbxActiveFiltersSnA = new TextBox();
            label1 = new Label();
            grpSiteData.SuspendLayout();
            grpRecord.SuspendLayout();
            grpVDF.SuspendLayout();
            menuStrip1.SuspendLayout();
            grpTagEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            grpActiveFilters.SuspendLayout();
            SuspendLayout();
            // 
            // grpSiteData
            // 
            grpSiteData.Controls.Add(lblSiteDataSiteCode);
            grpSiteData.Controls.Add(tbxSiteDataSlope);
            grpSiteData.Controls.Add(lblSiteDataSlope);
            grpSiteData.Controls.Add(tbxSiteDataOperator);
            grpSiteData.Controls.Add(lblSiteDataOperator);
            grpSiteData.Controls.Add(tbxSiteDataSiteCode);
            grpSiteData.Enabled = false;
            grpSiteData.Location = new Point(11, 227);
            grpSiteData.Name = "grpSiteData";
            grpSiteData.Size = new Size(178, 195);
            grpSiteData.TabIndex = 21;
            grpSiteData.TabStop = false;
            grpSiteData.Text = "SIte-Data";
            // 
            // lblSiteDataSiteCode
            // 
            lblSiteDataSiteCode.Location = new Point(14, 27);
            lblSiteDataSiteCode.Name = "lblSiteDataSiteCode";
            lblSiteDataSiteCode.Size = new Size(150, 20);
            lblSiteDataSiteCode.TabIndex = 5;
            lblSiteDataSiteCode.Text = "SiteCode";
            lblSiteDataSiteCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxSiteDataSlope
            // 
            tbxSiteDataSlope.Location = new Point(14, 155);
            tbxSiteDataSlope.Name = "tbxSiteDataSlope";
            tbxSiteDataSlope.Size = new Size(150, 27);
            tbxSiteDataSlope.TabIndex = 4;
            tbxSiteDataSlope.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSiteDataSlope
            // 
            lblSiteDataSlope.Location = new Point(14, 132);
            lblSiteDataSlope.Name = "lblSiteDataSlope";
            lblSiteDataSlope.Size = new Size(150, 20);
            lblSiteDataSlope.TabIndex = 3;
            lblSiteDataSlope.Text = "Slope";
            lblSiteDataSlope.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxSiteDataOperator
            // 
            tbxSiteDataOperator.Location = new Point(14, 101);
            tbxSiteDataOperator.Name = "tbxSiteDataOperator";
            tbxSiteDataOperator.Size = new Size(150, 27);
            tbxSiteDataOperator.TabIndex = 2;
            tbxSiteDataOperator.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSiteDataOperator
            // 
            lblSiteDataOperator.Location = new Point(14, 79);
            lblSiteDataOperator.Name = "lblSiteDataOperator";
            lblSiteDataOperator.Size = new Size(150, 20);
            lblSiteDataOperator.TabIndex = 1;
            lblSiteDataOperator.Text = "Operator";
            lblSiteDataOperator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxSiteDataSiteCode
            // 
            tbxSiteDataSiteCode.Location = new Point(14, 49);
            tbxSiteDataSiteCode.Name = "tbxSiteDataSiteCode";
            tbxSiteDataSiteCode.Size = new Size(150, 27);
            tbxSiteDataSiteCode.TabIndex = 0;
            tbxSiteDataSiteCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordCO2max
            // 
            lblRecordCO2max.Location = new Point(14, 507);
            lblRecordCO2max.Name = "lblRecordCO2max";
            lblRecordCO2max.Size = new Size(150, 20);
            lblRecordCO2max.TabIndex = 23;
            lblRecordCO2max.Text = "CO2 max";
            lblRecordCO2max.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecorduvSmoke
            // 
            tbxRecorduvSmoke.Location = new Point(14, 581);
            tbxRecorduvSmoke.Name = "tbxRecorduvSmoke";
            tbxRecorduvSmoke.Size = new Size(150, 27);
            tbxRecorduvSmoke.TabIndex = 20;
            tbxRecorduvSmoke.TextAlign = HorizontalAlignment.Center;
            // 
            // grpRecord
            // 
            grpRecord.Controls.Add(tbxRecordNH3ppm);
            grpRecord.Controls.Add(lblRecordNH3ppm);
            grpRecord.Controls.Add(tbxRecordNO2ppm);
            grpRecord.Controls.Add(lblRecordNO2ppm);
            grpRecord.Controls.Add(tbxRecordirSmoke);
            grpRecord.Controls.Add(lblRecordirSmoke);
            grpRecord.Controls.Add(lblRecordCO2max);
            grpRecord.Controls.Add(tbxRecorduvSmoke);
            grpRecord.Controls.Add(lblRecorduvSmoke);
            grpRecord.Controls.Add(tbxRecordCO2max);
            grpRecord.Controls.Add(lblRecordPerCO2);
            grpRecord.Controls.Add(tbxRecordNOppm);
            grpRecord.Controls.Add(lblRecordNOppm);
            grpRecord.Controls.Add(tbxRecordHCppm);
            grpRecord.Controls.Add(lblRecordHCppm);
            grpRecord.Controls.Add(tbxRecordPerCO2);
            grpRecord.Controls.Add(lblRecordAccel);
            grpRecord.Controls.Add(tbxRecordPerCO);
            grpRecord.Controls.Add(lblRecordPerCO);
            grpRecord.Controls.Add(tbxRecordVSP);
            grpRecord.Controls.Add(lblRecordVSP);
            grpRecord.Controls.Add(tbxRecordAccel);
            grpRecord.Controls.Add(lblRecordTime);
            grpRecord.Controls.Add(tbxRecordSpeed);
            grpRecord.Controls.Add(lblRecordSpeed);
            grpRecord.Controls.Add(tbxRecordCVAStatus);
            grpRecord.Controls.Add(lblRecordCVAStatus);
            grpRecord.Controls.Add(tbxRecordTime);
            grpRecord.Enabled = false;
            grpRecord.Location = new Point(1351, 41);
            grpRecord.Name = "grpRecord";
            grpRecord.Size = new Size(178, 780);
            grpRecord.TabIndex = 26;
            grpRecord.TabStop = false;
            grpRecord.Text = "Record";
            // 
            // tbxRecordNH3ppm
            // 
            tbxRecordNH3ppm.Location = new Point(14, 738);
            tbxRecordNH3ppm.Name = "tbxRecordNH3ppm";
            tbxRecordNH3ppm.Size = new Size(150, 27);
            tbxRecordNH3ppm.TabIndex = 29;
            tbxRecordNH3ppm.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordNH3ppm
            // 
            lblRecordNH3ppm.Location = new Point(14, 716);
            lblRecordNH3ppm.Name = "lblRecordNH3ppm";
            lblRecordNH3ppm.Size = new Size(150, 20);
            lblRecordNH3ppm.TabIndex = 28;
            lblRecordNH3ppm.Text = "NH3 ppm";
            lblRecordNH3ppm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordNO2ppm
            // 
            tbxRecordNO2ppm.Location = new Point(14, 686);
            tbxRecordNO2ppm.Name = "tbxRecordNO2ppm";
            tbxRecordNO2ppm.Size = new Size(150, 27);
            tbxRecordNO2ppm.TabIndex = 27;
            tbxRecordNO2ppm.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordNO2ppm
            // 
            lblRecordNO2ppm.Location = new Point(14, 664);
            lblRecordNO2ppm.Name = "lblRecordNO2ppm";
            lblRecordNO2ppm.Size = new Size(150, 20);
            lblRecordNO2ppm.TabIndex = 26;
            lblRecordNO2ppm.Text = "NO2 ppm";
            lblRecordNO2ppm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordirSmoke
            // 
            tbxRecordirSmoke.Location = new Point(14, 634);
            tbxRecordirSmoke.Name = "tbxRecordirSmoke";
            tbxRecordirSmoke.Size = new Size(150, 27);
            tbxRecordirSmoke.TabIndex = 25;
            tbxRecordirSmoke.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordirSmoke
            // 
            lblRecordirSmoke.Location = new Point(14, 612);
            lblRecordirSmoke.Name = "lblRecordirSmoke";
            lblRecordirSmoke.Size = new Size(150, 20);
            lblRecordirSmoke.TabIndex = 24;
            lblRecordirSmoke.Text = "ir Smoke";
            lblRecordirSmoke.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecorduvSmoke
            // 
            lblRecorduvSmoke.Location = new Point(14, 559);
            lblRecorduvSmoke.Name = "lblRecorduvSmoke";
            lblRecorduvSmoke.Size = new Size(150, 20);
            lblRecorduvSmoke.TabIndex = 19;
            lblRecorduvSmoke.Text = "uv Smoke";
            lblRecorduvSmoke.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordCO2max
            // 
            tbxRecordCO2max.Location = new Point(14, 529);
            tbxRecordCO2max.Name = "tbxRecordCO2max";
            tbxRecordCO2max.Size = new Size(150, 27);
            tbxRecordCO2max.TabIndex = 18;
            tbxRecordCO2max.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordPerCO2
            // 
            lblRecordPerCO2.Location = new Point(14, 347);
            lblRecordPerCO2.Name = "lblRecordPerCO2";
            lblRecordPerCO2.Size = new Size(150, 20);
            lblRecordPerCO2.TabIndex = 17;
            lblRecordPerCO2.Text = "%CO2";
            lblRecordPerCO2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordNOppm
            // 
            tbxRecordNOppm.Location = new Point(14, 475);
            tbxRecordNOppm.Name = "tbxRecordNOppm";
            tbxRecordNOppm.Size = new Size(150, 27);
            tbxRecordNOppm.TabIndex = 16;
            tbxRecordNOppm.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordNOppm
            // 
            lblRecordNOppm.Location = new Point(14, 452);
            lblRecordNOppm.Name = "lblRecordNOppm";
            lblRecordNOppm.Size = new Size(150, 20);
            lblRecordNOppm.TabIndex = 15;
            lblRecordNOppm.Text = "NO ppm";
            lblRecordNOppm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordHCppm
            // 
            tbxRecordHCppm.Location = new Point(14, 421);
            tbxRecordHCppm.Name = "tbxRecordHCppm";
            tbxRecordHCppm.Size = new Size(150, 27);
            tbxRecordHCppm.TabIndex = 14;
            tbxRecordHCppm.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordHCppm
            // 
            lblRecordHCppm.Location = new Point(14, 399);
            lblRecordHCppm.Name = "lblRecordHCppm";
            lblRecordHCppm.Size = new Size(150, 20);
            lblRecordHCppm.TabIndex = 13;
            lblRecordHCppm.Text = "HC ppm";
            lblRecordHCppm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordPerCO2
            // 
            tbxRecordPerCO2.Location = new Point(14, 369);
            tbxRecordPerCO2.Name = "tbxRecordPerCO2";
            tbxRecordPerCO2.Size = new Size(150, 27);
            tbxRecordPerCO2.TabIndex = 12;
            tbxRecordPerCO2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordAccel
            // 
            lblRecordAccel.Location = new Point(14, 187);
            lblRecordAccel.Name = "lblRecordAccel";
            lblRecordAccel.Size = new Size(150, 20);
            lblRecordAccel.TabIndex = 11;
            lblRecordAccel.Text = "Accel";
            lblRecordAccel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordPerCO
            // 
            tbxRecordPerCO.Location = new Point(14, 315);
            tbxRecordPerCO.Name = "tbxRecordPerCO";
            tbxRecordPerCO.Size = new Size(150, 27);
            tbxRecordPerCO.TabIndex = 10;
            tbxRecordPerCO.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordPerCO
            // 
            lblRecordPerCO.Location = new Point(14, 292);
            lblRecordPerCO.Name = "lblRecordPerCO";
            lblRecordPerCO.Size = new Size(150, 20);
            lblRecordPerCO.TabIndex = 9;
            lblRecordPerCO.Text = "%CO";
            lblRecordPerCO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordVSP
            // 
            tbxRecordVSP.Location = new Point(14, 261);
            tbxRecordVSP.Name = "tbxRecordVSP";
            tbxRecordVSP.Size = new Size(150, 27);
            tbxRecordVSP.TabIndex = 8;
            tbxRecordVSP.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordVSP
            // 
            lblRecordVSP.Location = new Point(14, 239);
            lblRecordVSP.Name = "lblRecordVSP";
            lblRecordVSP.Size = new Size(150, 20);
            lblRecordVSP.TabIndex = 7;
            lblRecordVSP.Text = "VSP";
            lblRecordVSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordAccel
            // 
            tbxRecordAccel.Location = new Point(14, 209);
            tbxRecordAccel.Name = "tbxRecordAccel";
            tbxRecordAccel.Size = new Size(150, 27);
            tbxRecordAccel.TabIndex = 6;
            tbxRecordAccel.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordTime
            // 
            lblRecordTime.Location = new Point(14, 27);
            lblRecordTime.Name = "lblRecordTime";
            lblRecordTime.Size = new Size(150, 20);
            lblRecordTime.TabIndex = 5;
            lblRecordTime.Text = "Time";
            lblRecordTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordSpeed
            // 
            tbxRecordSpeed.Location = new Point(14, 155);
            tbxRecordSpeed.Name = "tbxRecordSpeed";
            tbxRecordSpeed.Size = new Size(150, 27);
            tbxRecordSpeed.TabIndex = 4;
            tbxRecordSpeed.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordSpeed
            // 
            lblRecordSpeed.Location = new Point(14, 132);
            lblRecordSpeed.Name = "lblRecordSpeed";
            lblRecordSpeed.Size = new Size(150, 20);
            lblRecordSpeed.TabIndex = 3;
            lblRecordSpeed.Text = "Speed";
            lblRecordSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordCVAStatus
            // 
            tbxRecordCVAStatus.Location = new Point(14, 101);
            tbxRecordCVAStatus.Name = "tbxRecordCVAStatus";
            tbxRecordCVAStatus.Size = new Size(150, 27);
            tbxRecordCVAStatus.TabIndex = 2;
            tbxRecordCVAStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRecordCVAStatus
            // 
            lblRecordCVAStatus.Location = new Point(14, 79);
            lblRecordCVAStatus.Name = "lblRecordCVAStatus";
            lblRecordCVAStatus.Size = new Size(150, 20);
            lblRecordCVAStatus.TabIndex = 1;
            lblRecordCVAStatus.Text = "CVA Status";
            lblRecordCVAStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxRecordTime
            // 
            tbxRecordTime.Location = new Point(14, 49);
            tbxRecordTime.Name = "tbxRecordTime";
            tbxRecordTime.Size = new Size(150, 27);
            tbxRecordTime.TabIndex = 0;
            tbxRecordTime.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOptionsGoToVDF
            // 
            btnOptionsGoToVDF.Location = new Point(1006, 95);
            btnOptionsGoToVDF.Name = "btnOptionsGoToVDF";
            btnOptionsGoToVDF.Size = new Size(101, 43);
            btnOptionsGoToVDF.TabIndex = 8;
            btnOptionsGoToVDF.Text = "Go To VDF#";
            btnOptionsGoToVDF.UseVisualStyleBackColor = true;
            btnOptionsGoToVDF.Click += btnOptionsGoToVDF_Click;
            // 
            // tbxOptionsGoToVDF
            // 
            tbxOptionsGoToVDF.Location = new Point(1007, 61);
            tbxOptionsGoToVDF.Name = "tbxOptionsGoToVDF";
            tbxOptionsGoToVDF.Size = new Size(101, 27);
            tbxOptionsGoToVDF.TabIndex = 7;
            tbxOptionsGoToVDF.TextAlign = HorizontalAlignment.Center;
            tbxOptionsGoToVDF.KeyPress += tbxOptionsGoToVDF_KeyPress;
            // 
            // tbxState
            // 
            tbxState.Enabled = false;
            tbxState.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxState.Location = new Point(21, 95);
            tbxState.MaxLength = 2;
            tbxState.Name = "tbxState";
            tbxState.Size = new Size(60, 43);
            tbxState.TabIndex = 1;
            tbxState.KeyPress += tbxState_KeyPress;
            // 
            // lblVDFPlate
            // 
            lblVDFPlate.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblVDFPlate.Location = new Point(21, 53);
            lblVDFPlate.Name = "lblVDFPlate";
            lblVDFPlate.Size = new Size(240, 39);
            lblVDFPlate.TabIndex = 4;
            lblVDFPlate.Text = "Plate";
            lblVDFPlate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblShowHotKeys
            // 
            lblShowHotKeys.ForeColor = Color.Blue;
            lblShowHotKeys.Location = new Point(1164, 822);
            lblShowHotKeys.Name = "lblShowHotKeys";
            lblShowHotKeys.Size = new Size(178, 20);
            lblShowHotKeys.TabIndex = 24;
            lblShowHotKeys.Text = "F1 - Show Hotkeys";
            lblShowHotKeys.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVDFUneditedRecords
            // 
            lblVDFUneditedRecords.Location = new Point(825, 27);
            lblVDFUneditedRecords.Name = "lblVDFUneditedRecords";
            lblVDFUneditedRecords.Size = new Size(283, 20);
            lblVDFUneditedRecords.TabIndex = 3;
            lblVDFUneditedRecords.Text = "7 Unedited Records";
            lblVDFUneditedRecords.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVDFNoofRecords
            // 
            lblVDFNoofRecords.Location = new Point(21, 27);
            lblVDFNoofRecords.Name = "lblVDFNoofRecords";
            lblVDFNoofRecords.Size = new Size(283, 20);
            lblVDFNoofRecords.TabIndex = 2;
            lblVDFNoofRecords.Text = "Record 1 of 105";
            lblVDFNoofRecords.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxVDFPlate
            // 
            tbxVDFPlate.Enabled = false;
            tbxVDFPlate.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxVDFPlate.Location = new Point(79, 95);
            tbxVDFPlate.MaxLength = 10;
            tbxVDFPlate.Name = "tbxVDFPlate";
            tbxVDFPlate.Size = new Size(182, 43);
            tbxVDFPlate.TabIndex = 1;
            tbxVDFPlate.KeyPress += tbxVDFPlate_KeyPress;
            // 
            // btnVDFAccept
            // 
            btnVDFAccept.Location = new Point(876, 95);
            btnVDFAccept.Name = "btnVDFAccept";
            btnVDFAccept.Size = new Size(120, 43);
            btnVDFAccept.TabIndex = 6;
            btnVDFAccept.Text = "EDIT (enter)";
            btnVDFAccept.UseVisualStyleBackColor = true;
            btnVDFAccept.Click += btnVDFAccept_Click;
            // 
            // lblZoomIn
            // 
            lblZoomIn.ForeColor = Color.Blue;
            lblZoomIn.Location = new Point(1164, 801);
            lblZoomIn.Name = "lblZoomIn";
            lblZoomIn.Size = new Size(178, 20);
            lblZoomIn.TabIndex = 23;
            lblZoomIn.Text = "Left CLick = Zoom In";
            lblZoomIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZoomOut
            // 
            lblZoomOut.ForeColor = Color.Blue;
            lblZoomOut.Location = new Point(1164, 782);
            lblZoomOut.Name = "lblZoomOut";
            lblZoomOut.Size = new Size(178, 20);
            lblZoomOut.TabIndex = 22;
            lblZoomOut.Text = "Right Click = Zoom Out";
            lblZoomOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrTimer
            // 
            tmrTimer.Enabled = true;
            tmrTimer.Interval = 1000;
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // grpVDF
            // 
            grpVDF.Controls.Add(label1);
            grpVDF.Controls.Add(cbxVehMfgCode);
            grpVDF.Controls.Add(cbxVehPlateCode);
            grpVDF.Controls.Add(cbxVehTypeCode);
            grpVDF.Controls.Add(cbxVehCatCode);
            grpVDF.Controls.Add(lblVehPlateCode);
            grpVDF.Controls.Add(lblVehTypeCode);
            grpVDF.Controls.Add(lblVehCatCode);
            grpVDF.Controls.Add(btnOptionsGoToVDF);
            grpVDF.Controls.Add(tbxOptionsGoToVDF);
            grpVDF.Controls.Add(tbxState);
            grpVDF.Controls.Add(lblVDFPlate);
            grpVDF.Controls.Add(lblVDFUneditedRecords);
            grpVDF.Controls.Add(lblVDFNoofRecords);
            grpVDF.Controls.Add(tbxVDFPlate);
            grpVDF.Controls.Add(btnVDFAccept);
            grpVDF.Location = new Point(25, 755);
            grpVDF.Name = "grpVDF";
            grpVDF.Size = new Size(1133, 152);
            grpVDF.TabIndex = 25;
            grpVDF.TabStop = false;
            grpVDF.Text = "VDF 1";
            // 
            // cbxVehMfgCode
            // 
            cbxVehMfgCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVehMfgCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbxVehMfgCode.FormattingEnabled = true;
            cbxVehMfgCode.Location = new Point(633, 105);
            cbxVehMfgCode.Name = "cbxVehMfgCode";
            cbxVehMfgCode.Size = new Size(220, 33);
            cbxVehMfgCode.TabIndex = 5;
            // 
            // cbxVehPlateCode
            // 
            cbxVehPlateCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVehPlateCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbxVehPlateCode.FormattingEnabled = true;
            cbxVehPlateCode.Location = new Point(530, 105);
            cbxVehPlateCode.Name = "cbxVehPlateCode";
            cbxVehPlateCode.Size = new Size(80, 33);
            cbxVehPlateCode.TabIndex = 4;
            // 
            // cbxVehTypeCode
            // 
            cbxVehTypeCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVehTypeCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbxVehTypeCode.FormattingEnabled = true;
            cbxVehTypeCode.Location = new Point(387, 105);
            cbxVehTypeCode.Name = "cbxVehTypeCode";
            cbxVehTypeCode.Size = new Size(120, 33);
            cbxVehTypeCode.TabIndex = 3;
            // 
            // cbxVehCatCode
            // 
            cbxVehCatCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVehCatCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbxVehCatCode.FormattingEnabled = true;
            cbxVehCatCode.Location = new Point(284, 105);
            cbxVehCatCode.Name = "cbxVehCatCode";
            cbxVehCatCode.Size = new Size(80, 33);
            cbxVehCatCode.TabIndex = 2;
            // 
            // lblVehPlateCode
            // 
            lblVehPlateCode.Location = new Point(530, 72);
            lblVehPlateCode.Name = "lblVehPlateCode";
            lblVehPlateCode.Size = new Size(100, 20);
            lblVehPlateCode.TabIndex = 9;
            lblVehPlateCode.Text = "Plate Code";
            lblVehPlateCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVehTypeCode
            // 
            lblVehTypeCode.Location = new Point(387, 72);
            lblVehTypeCode.Name = "lblVehTypeCode";
            lblVehTypeCode.Size = new Size(100, 20);
            lblVehTypeCode.TabIndex = 8;
            lblVehTypeCode.Text = "Type Code";
            lblVehTypeCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVehCatCode
            // 
            lblVehCatCode.Location = new Point(284, 72);
            lblVehCatCode.Name = "lblVehCatCode";
            lblVehCatCode.Size = new Size(100, 20);
            lblVehCatCode.TabIndex = 7;
            lblVehCatCode.Text = "Cat. Code";
            lblVehCatCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSelectDatabasefromfilemenu
            // 
            lblSelectDatabasefromfilemenu.BackColor = Color.FromArgb(0, 0, 192);
            lblSelectDatabasefromfilemenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectDatabasefromfilemenu.ForeColor = Color.White;
            lblSelectDatabasefromfilemenu.Location = new Point(198, 415);
            lblSelectDatabasefromfilemenu.Name = "lblSelectDatabasefromfilemenu";
            lblSelectDatabasefromfilemenu.Size = new Size(1144, 48);
            lblSelectDatabasefromfilemenu.TabIndex = 20;
            lblSelectDatabasefromfilemenu.Text = "Select Database from File Menu";
            lblSelectDatabasefromfilemenu.TextAlign = ContentAlignment.TopCenter;
            // 
            // ofdConsoleDB
            // 
            ofdConsoleDB.FileName = "openFileDialog1";
            // 
            // lblNoDatabaseLoaded
            // 
            lblNoDatabaseLoaded.BackColor = Color.FromArgb(0, 0, 192);
            lblNoDatabaseLoaded.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoDatabaseLoaded.ForeColor = Color.White;
            lblNoDatabaseLoaded.Location = new Point(198, 335);
            lblNoDatabaseLoaded.Name = "lblNoDatabaseLoaded";
            lblNoDatabaseLoaded.Size = new Size(1144, 48);
            lblNoDatabaseLoaded.TabIndex = 19;
            lblNoDatabaseLoaded.Text = "NO DATABASE LOADED";
            lblNoDatabaseLoaded.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuCleanScreen
            // 
            menuCleanScreen.Name = "menuCleanScreen";
            menuCleanScreen.Size = new Size(219, 26);
            menuCleanScreen.Text = "CleanScreen";
            menuCleanScreen.Click += menuCleanScreen_Click;
            // 
            // menuConfiguration
            // 
            menuConfiguration.DropDownItems.AddRange(new ToolStripItem[] { menuCleanScreen, menuFilterAll, menuGrossEmitter, menuOHIO, menuShowAll, menuSPConfiguration1, menuEditConfigurations });
            menuConfiguration.Name = "menuConfiguration";
            menuConfiguration.Size = new Size(114, 24);
            menuConfiguration.Text = "Configuration";
            menuConfiguration.Visible = false;
            // 
            // menuFilterAll
            // 
            menuFilterAll.Name = "menuFilterAll";
            menuFilterAll.Size = new Size(219, 26);
            menuFilterAll.Text = "Filter All";
            menuFilterAll.Click += menuFilterAll_Click;
            // 
            // menuGrossEmitter
            // 
            menuGrossEmitter.Name = "menuGrossEmitter";
            menuGrossEmitter.Size = new Size(219, 26);
            menuGrossEmitter.Text = "Gross Emitter";
            menuGrossEmitter.Click += menuGrossEmitter_Click;
            // 
            // menuOHIO
            // 
            menuOHIO.Name = "menuOHIO";
            menuOHIO.Size = new Size(219, 26);
            menuOHIO.Text = "OHIO";
            menuOHIO.Click += menuOHIO_Click;
            // 
            // menuShowAll
            // 
            menuShowAll.Name = "menuShowAll";
            menuShowAll.Size = new Size(219, 26);
            menuShowAll.Text = "Show All";
            menuShowAll.Click += menuShowAll_Click;
            // 
            // menuSPConfiguration1
            // 
            menuSPConfiguration1.Name = "menuSPConfiguration1";
            menuSPConfiguration1.Size = new Size(216, 6);
            // 
            // menuEditConfigurations
            // 
            menuEditConfigurations.Name = "menuEditConfigurations";
            menuEditConfigurations.Size = new Size(219, 26);
            menuEditConfigurations.Text = "Edit Configurations";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Control | Keys.Q;
            menuExit.Size = new Size(285, 26);
            menuExit.Text = "Exit";
            menuExit.Click += menuExit_Click;
            // 
            // menuSPFile3
            // 
            menuSPFile3.Name = "menuSPFile3";
            menuSPFile3.Size = new Size(282, 6);
            // 
            // menuCloseDatabase
            // 
            menuCloseDatabase.Name = "menuCloseDatabase";
            menuCloseDatabase.ShortcutKeys = Keys.Control | Keys.X;
            menuCloseDatabase.Size = new Size(285, 26);
            menuCloseDatabase.Text = "Close Database";
            menuCloseDatabase.Click += menuCloseDatabase_Click;
            // 
            // menuExportCSVDatabase
            // 
            menuExportCSVDatabase.Name = "menuExportCSVDatabase";
            menuExportCSVDatabase.ShortcutKeys = Keys.Control | Keys.D;
            menuExportCSVDatabase.Size = new Size(285, 26);
            menuExportCSVDatabase.Text = "Export CSV Database";
            menuExportCSVDatabase.Click += menuExportCSVDatabase_Click;
            // 
            // menuSPFile2
            // 
            menuSPFile2.Name = "menuSPFile2";
            menuSPFile2.Size = new Size(282, 6);
            // 
            // menuOpenVIDDB
            // 
            menuOpenVIDDB.Name = "menuOpenVIDDB";
            menuOpenVIDDB.ShortcutKeys = Keys.Control | Keys.V;
            menuOpenVIDDB.Size = new Size(285, 26);
            menuOpenVIDDB.Text = "Open VID DB";
            // 
            // menuOpenConsoleDB
            // 
            menuOpenConsoleDB.Name = "menuOpenConsoleDB";
            menuOpenConsoleDB.ShortcutKeys = Keys.Control | Keys.C;
            menuOpenConsoleDB.Size = new Size(285, 26);
            menuOpenConsoleDB.Text = "Open Console DB";
            menuOpenConsoleDB.Click += menuOpenConsoleDB_Click;
            // 
            // menuOpenLiveDB
            // 
            menuOpenLiveDB.Enabled = false;
            menuOpenLiveDB.Name = "menuOpenLiveDB";
            menuOpenLiveDB.ShortcutKeys = Keys.Control | Keys.L;
            menuOpenLiveDB.Size = new Size(285, 26);
            menuOpenLiveDB.Text = "Open Live DB";
            // 
            // menuSPFile1
            // 
            menuSPFile1.Name = "menuSPFile1";
            menuSPFile1.Size = new Size(282, 6);
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(285, 26);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuSPFile1, menuOpenLiveDB, menuOpenConsoleDB, menuOpenVIDDB, menuSPFile2, menuExportCSVNOtice, menuExportCSVDatabase, menuCloseDatabase, menuSPFile3, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuExportCSVNOtice
            // 
            menuExportCSVNOtice.Name = "menuExportCSVNOtice";
            menuExportCSVNOtice.ShortcutKeyDisplayString = "";
            menuExportCSVNOtice.ShortcutKeys = Keys.Control | Keys.N;
            menuExportCSVNOtice.Size = new Size(285, 26);
            menuExportCSVNOtice.Text = "Export CSV Notice";
            menuExportCSVNOtice.Click += menuExportCSVNOtice_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuConfiguration, menuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1543, 30);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuAbout });
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(55, 24);
            menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(133, 26);
            menuAbout.Text = "About";
            menuAbout.Click += menuAbout_Click;
            // 
            // tbxTagEditTime
            // 
            tbxTagEditTime.Location = new Point(14, 136);
            tbxTagEditTime.Name = "tbxTagEditTime";
            tbxTagEditTime.Size = new Size(150, 27);
            tbxTagEditTime.TabIndex = 4;
            tbxTagEditTime.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTagEditTime
            // 
            lblTagEditTime.Location = new Point(14, 115);
            lblTagEditTime.Name = "lblTagEditTime";
            lblTagEditTime.Size = new Size(150, 27);
            lblTagEditTime.TabIndex = 3;
            lblTagEditTime.Text = "Time";
            lblTagEditTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxTagEditDate
            // 
            tbxTagEditDate.Location = new Point(14, 80);
            tbxTagEditDate.Name = "tbxTagEditDate";
            tbxTagEditDate.Size = new Size(150, 27);
            tbxTagEditDate.TabIndex = 2;
            tbxTagEditDate.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTagEditDate
            // 
            lblTagEditDate.Location = new Point(14, 56);
            lblTagEditDate.Name = "lblTagEditDate";
            lblTagEditDate.Size = new Size(150, 27);
            lblTagEditDate.TabIndex = 1;
            lblTagEditDate.Text = "Date";
            lblTagEditDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxTagEditUser
            // 
            tbxTagEditUser.Location = new Point(14, 27);
            tbxTagEditUser.Name = "tbxTagEditUser";
            tbxTagEditUser.Size = new Size(150, 27);
            tbxTagEditUser.TabIndex = 0;
            tbxTagEditUser.TextAlign = HorizontalAlignment.Center;
            // 
            // grpTagEditor
            // 
            grpTagEditor.Controls.Add(tbxTagEditTime);
            grpTagEditor.Controls.Add(lblTagEditTime);
            grpTagEditor.Controls.Add(tbxTagEditDate);
            grpTagEditor.Controls.Add(lblTagEditDate);
            grpTagEditor.Controls.Add(tbxTagEditUser);
            grpTagEditor.Enabled = false;
            grpTagEditor.Location = new Point(11, 41);
            grpTagEditor.Name = "grpTagEditor";
            grpTagEditor.Size = new Size(178, 177);
            grpTagEditor.TabIndex = 15;
            grpTagEditor.TabStop = false;
            grpTagEditor.Text = "Tag-Editor";
            // 
            // pbxImage
            // 
            pbxImage.BackColor = Color.FromArgb(0, 150, 192);
            pbxImage.Location = new Point(197, 41);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(1147, 703);
            pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImage.TabIndex = 18;
            pbxImage.TabStop = false;
            // 
            // lblActiveFilters
            // 
            lblActiveFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblActiveFilters.ForeColor = Color.Blue;
            lblActiveFilters.Location = new Point(14, 21);
            lblActiveFilters.Name = "lblActiveFilters";
            lblActiveFilters.Size = new Size(150, 20);
            lblActiveFilters.TabIndex = 10;
            lblActiveFilters.Text = "OHIO";
            lblActiveFilters.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxActiveFiltersCleanScreen
            // 
            tbxActiveFiltersCleanScreen.Location = new Point(14, 255);
            tbxActiveFiltersCleanScreen.Name = "tbxActiveFiltersCleanScreen";
            tbxActiveFiltersCleanScreen.Size = new Size(150, 27);
            tbxActiveFiltersCleanScreen.TabIndex = 9;
            tbxActiveFiltersCleanScreen.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxActiveFiltersALPR
            // 
            tbxActiveFiltersALPR.Location = new Point(14, 225);
            tbxActiveFiltersALPR.Name = "tbxActiveFiltersALPR";
            tbxActiveFiltersALPR.Size = new Size(150, 27);
            tbxActiveFiltersALPR.TabIndex = 8;
            tbxActiveFiltersALPR.Text = "ALPR";
            tbxActiveFiltersALPR.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxActiveFiltersAccel
            // 
            tbxActiveFiltersAccel.Location = new Point(14, 195);
            tbxActiveFiltersAccel.Name = "tbxActiveFiltersAccel";
            tbxActiveFiltersAccel.Size = new Size(150, 27);
            tbxActiveFiltersAccel.TabIndex = 7;
            tbxActiveFiltersAccel.Text = "Accel";
            tbxActiveFiltersAccel.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxActiveFiltersSpeed
            // 
            tbxActiveFiltersSpeed.Location = new Point(14, 165);
            tbxActiveFiltersSpeed.Name = "tbxActiveFiltersSpeed";
            tbxActiveFiltersSpeed.Size = new Size(150, 27);
            tbxActiveFiltersSpeed.TabIndex = 6;
            tbxActiveFiltersSpeed.Text = "Speed";
            tbxActiveFiltersSpeed.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxActiveFiltersVSP
            // 
            tbxActiveFiltersVSP.Location = new Point(14, 135);
            tbxActiveFiltersVSP.Name = "tbxActiveFiltersVSP";
            tbxActiveFiltersVSP.Size = new Size(150, 27);
            tbxActiveFiltersVSP.TabIndex = 5;
            tbxActiveFiltersVSP.Text = "VSP";
            tbxActiveFiltersVSP.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxActiveFiltersCVA
            // 
            tbxActiveFiltersCVA.Location = new Point(14, 105);
            tbxActiveFiltersCVA.Name = "tbxActiveFiltersCVA";
            tbxActiveFiltersCVA.Size = new Size(150, 27);
            tbxActiveFiltersCVA.TabIndex = 4;
            tbxActiveFiltersCVA.Text = "CVA";
            tbxActiveFiltersCVA.TextAlign = HorizontalAlignment.Center;
            // 
            // grpActiveFilters
            // 
            grpActiveFilters.Controls.Add(lblActiveFilters);
            grpActiveFilters.Controls.Add(tbxActiveFiltersCleanScreen);
            grpActiveFilters.Controls.Add(tbxActiveFiltersALPR);
            grpActiveFilters.Controls.Add(tbxActiveFiltersAccel);
            grpActiveFilters.Controls.Add(tbxActiveFiltersSpeed);
            grpActiveFilters.Controls.Add(tbxActiveFiltersVSP);
            grpActiveFilters.Controls.Add(tbxActiveFiltersCVA);
            grpActiveFilters.Controls.Add(tbxActiveFiltersGas);
            grpActiveFilters.Controls.Add(tbxActiveFiltersSnA);
            grpActiveFilters.Enabled = false;
            grpActiveFilters.Location = new Point(11, 431);
            grpActiveFilters.Name = "grpActiveFilters";
            grpActiveFilters.Size = new Size(178, 288);
            grpActiveFilters.TabIndex = 17;
            grpActiveFilters.TabStop = false;
            grpActiveFilters.Text = "Active-Filters";
            // 
            // tbxActiveFiltersGas
            // 
            tbxActiveFiltersGas.BackColor = Color.Lime;
            tbxActiveFiltersGas.Location = new Point(14, 75);
            tbxActiveFiltersGas.Name = "tbxActiveFiltersGas";
            tbxActiveFiltersGas.Size = new Size(150, 27);
            tbxActiveFiltersGas.TabIndex = 2;
            tbxActiveFiltersGas.Text = "Gas";
            tbxActiveFiltersGas.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxActiveFiltersSnA
            // 
            tbxActiveFiltersSnA.BackColor = Color.Lime;
            tbxActiveFiltersSnA.Location = new Point(14, 45);
            tbxActiveFiltersSnA.Name = "tbxActiveFiltersSnA";
            tbxActiveFiltersSnA.Size = new Size(150, 27);
            tbxActiveFiltersSnA.TabIndex = 0;
            tbxActiveFiltersSnA.Text = "S/A";
            tbxActiveFiltersSnA.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Location = new Point(633, 72);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 10;
            label1.Text = "Mfg. Code";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TagEditor_OPUS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 916);
            Controls.Add(grpSiteData);
            Controls.Add(grpRecord);
            Controls.Add(lblShowHotKeys);
            Controls.Add(lblZoomIn);
            Controls.Add(lblZoomOut);
            Controls.Add(grpVDF);
            Controls.Add(lblSelectDatabasefromfilemenu);
            Controls.Add(lblNoDatabaseLoaded);
            Controls.Add(menuStrip1);
            Controls.Add(grpTagEditor);
            Controls.Add(pbxImage);
            Controls.Add(grpActiveFilters);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "TagEditor_OPUS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TagEditor - OPUS RSD";
            FormClosing += TagEditor_OPUS_FormClosing;
            Load += TagEditor_OPUS_Load;
            KeyDown += TagEditor_OPUS_KeyDown;
            grpSiteData.ResumeLayout(false);
            grpSiteData.PerformLayout();
            grpRecord.ResumeLayout(false);
            grpRecord.PerformLayout();
            grpVDF.ResumeLayout(false);
            grpVDF.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpTagEditor.ResumeLayout(false);
            grpTagEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            grpActiveFilters.ResumeLayout(false);
            grpActiveFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSiteData;
        private Label lblSiteDataSiteCode;
        private TextBox tbxSiteDataSlope;
        private Label lblSiteDataSlope;
        private TextBox tbxSiteDataOperator;
        private Label lblSiteDataOperator;
        private TextBox tbxSiteDataSiteCode;
        private Label lblRecordCO2max;
        private TextBox tbxRecorduvSmoke;
        private GroupBox grpRecord;
        private Label lblRecorduvSmoke;
        private TextBox tbxRecordCO2max;
        private Label lblRecordPerCO2;
        private TextBox tbxRecordNOppm;
        private Label lblRecordNOppm;
        private TextBox tbxRecordHCppm;
        private Label lblRecordHCppm;
        private TextBox tbxRecordPerCO2;
        private Label lblRecordAccel;
        private TextBox tbxRecordPerCO;
        private Label lblRecordPerCO;
        private TextBox tbxRecordVSP;
        private Label lblRecordVSP;
        private TextBox tbxRecordAccel;
        private Label lblRecordTime;
        private TextBox tbxRecordSpeed;
        private Label lblRecordSpeed;
        private TextBox tbxRecordCVAStatus;
        private Label lblRecordCVAStatus;
        private TextBox tbxRecordTime;
        private Button btnOptionsGoToVDF;
        private TextBox tbxOptionsGoToVDF;
        private TextBox tbxState;
        private Label lblVDFPlate;
        private Label lblShowHotKeys;
        private Label lblVDFUneditedRecords;
        private Label lblVDFNoofRecords;
        private TextBox tbxVDFPlate;
        private Button btnVDFAccept;
        private Label lblZoomIn;
        private Label lblZoomOut;
        private System.Windows.Forms.Timer tmrTimer;
        private GroupBox grpVDF;
        private Label lblSelectDatabasefromfilemenu;
        private OpenFileDialog ofdConsoleDB;
        private Label lblNoDatabaseLoaded;
        private ToolStripMenuItem menuCleanScreen;
        private ToolStripMenuItem menuConfiguration;
        private ToolStripMenuItem menuFilterAll;
        private ToolStripMenuItem menuGrossEmitter;
        private ToolStripMenuItem menuOHIO;
        private ToolStripMenuItem menuShowAll;
        private ToolStripSeparator menuSPConfiguration1;
        private ToolStripMenuItem menuEditConfigurations;
        private ToolStripMenuItem menuExit;
        private ToolStripSeparator menuSPFile3;
        private ToolStripMenuItem menuCloseDatabase;
        private ToolStripMenuItem menuExportCSVDatabase;
        private ToolStripSeparator menuSPFile2;
        private ToolStripMenuItem menuOpenVIDDB;
        private ToolStripMenuItem menuOpenConsoleDB;
        private ToolStripMenuItem menuOpenLiveDB;
        private ToolStripSeparator menuSPFile1;
        private ToolStripMenuItem menuLogin;
        private ToolStripMenuItem menuFile;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuAbout;
        private TextBox tbxTagEditTime;
        private Label lblTagEditTime;
        private TextBox tbxTagEditDate;
        private Label lblTagEditDate;
        private TextBox tbxTagEditUser;
        private GroupBox grpTagEditor;
        private PictureBox pbxImage;
        private Label lblActiveFilters;
        private TextBox tbxActiveFiltersCleanScreen;
        private TextBox tbxActiveFiltersALPR;
        private TextBox tbxActiveFiltersAccel;
        private TextBox tbxActiveFiltersSpeed;
        private TextBox tbxActiveFiltersVSP;
        private TextBox tbxActiveFiltersCVA;
        private GroupBox grpActiveFilters;
        private TextBox tbxActiveFiltersGas;
        private TextBox tbxActiveFiltersSnA;
        private TextBox tbxRecordNH3ppm;
        private Label lblRecordNH3ppm;
        private TextBox tbxRecordNO2ppm;
        private Label lblRecordNO2ppm;
        private TextBox tbxRecordirSmoke;
        private Label lblRecordirSmoke;
        private Label lblVehCatCode;
        private Label lblVehTypeCode;
        private Label lblVehPlateCode;
        private ComboBox cbxVehPlateCode;
        private ComboBox cbxVehTypeCode;
        private ComboBox cbxVehCatCode;
        private ToolStripMenuItem menuExportCSVNOtice;
        private ComboBox cbxVehMfgCode;
        private Label label1;
    }
}
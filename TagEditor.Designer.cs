namespace TagEdit.Net
{
    partial class TagEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpTagEditor = new GroupBox();
            tbxTagEditTime = new TextBox();
            lblTagEditTime = new Label();
            tbxTagEditDate = new TextBox();
            lblTagEditDate = new Label();
            tbxTagEditUser = new TextBox();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuSPFile1 = new ToolStripSeparator();
            menuOpenLiveDB = new ToolStripMenuItem();
            menuOpenConsoleDB = new ToolStripMenuItem();
            menuOpenVIDDB = new ToolStripMenuItem();
            menuSPFile2 = new ToolStripSeparator();
            menuExportCSVDatabase = new ToolStripMenuItem();
            menuCloseDatabase = new ToolStripMenuItem();
            menuSPFile3 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            menuConfiguration = new ToolStripMenuItem();
            menuCleanScreen = new ToolStripMenuItem();
            menuFilterAll = new ToolStripMenuItem();
            menuGrossEmitter = new ToolStripMenuItem();
            menuOHIO = new ToolStripMenuItem();
            menuShowAll = new ToolStripMenuItem();
            menuSPConfiguration1 = new ToolStripSeparator();
            menuEditConfigurations = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            grpActiveFilters = new GroupBox();
            lblActiveFilters = new Label();
            tbxActiveFiltersCleanScreen = new TextBox();
            tbxActiveFiltersALPR = new TextBox();
            tbxActiveFiltersAccel = new TextBox();
            tbxActiveFiltersSpeed = new TextBox();
            tbxActiveFiltersVSP = new TextBox();
            tbxActiveFiltersCVA = new TextBox();
            tbxActiveFiltersGas = new TextBox();
            tbxActiveFiltersSnA = new TextBox();
            pbxImage = new PictureBox();
            lblNoDatabaseLoaded = new Label();
            lblSelectDatabasefromfilemenu = new Label();
            grpSiteData = new GroupBox();
            lblSiteDataSiteCode = new Label();
            tbxSiteDataSlope = new TextBox();
            lblSiteDataSlope = new Label();
            tbxSiteDataOperator = new TextBox();
            lblSiteDataOperator = new Label();
            tbxSiteDataSiteCode = new TextBox();
            lblZoomOut = new Label();
            lblZoomIn = new Label();
            lblShowHotKeys = new Label();
            btnOptionsGoToVDF = new Button();
            tbxOptionsGoToVDF = new TextBox();
            grpVDF = new GroupBox();
            tbxState = new TextBox();
            lblVDFPlate = new Label();
            lblVDFUneditedRecords = new Label();
            lblVDFNoofRecords = new Label();
            tbxVDFPlate = new TextBox();
            btnVDFAccept = new Button();
            grpRecord = new GroupBox();
            lblRecordCO2max = new Label();
            tbxRecorduvSmoke = new TextBox();
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
            tmrTimer = new System.Windows.Forms.Timer(components);
            ofdConsoleDB = new OpenFileDialog();
            grpTagEditor.SuspendLayout();
            menuStrip1.SuspendLayout();
            grpActiveFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            grpSiteData.SuspendLayout();
            grpVDF.SuspendLayout();
            grpRecord.SuspendLayout();
            SuspendLayout();
            // 
            // grpTagEditor
            // 
            grpTagEditor.Controls.Add(tbxTagEditTime);
            grpTagEditor.Controls.Add(lblTagEditTime);
            grpTagEditor.Controls.Add(tbxTagEditDate);
            grpTagEditor.Controls.Add(lblTagEditDate);
            grpTagEditor.Controls.Add(tbxTagEditUser);
            grpTagEditor.Enabled = false;
            grpTagEditor.Location = new Point(11, 31);
            grpTagEditor.Name = "grpTagEditor";
            grpTagEditor.Size = new Size(178, 177);
            grpTagEditor.TabIndex = 0;
            grpTagEditor.TabStop = false;
            grpTagEditor.Text = "Tag-Editor";
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuConfiguration, menuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1543, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuSPFile1, menuOpenLiveDB, menuOpenConsoleDB, menuOpenVIDDB, menuSPFile2, menuExportCSVDatabase, menuCloseDatabase, menuSPFile3, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(285, 26);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuSPFile1
            // 
            menuSPFile1.Name = "menuSPFile1";
            menuSPFile1.Size = new Size(282, 6);
            // 
            // menuOpenLiveDB
            // 
            menuOpenLiveDB.Enabled = false;
            menuOpenLiveDB.Name = "menuOpenLiveDB";
            menuOpenLiveDB.ShortcutKeys = Keys.Control | Keys.L;
            menuOpenLiveDB.Size = new Size(285, 26);
            menuOpenLiveDB.Text = "Open Live DB";
            // 
            // menuOpenConsoleDB
            // 
            menuOpenConsoleDB.Name = "menuOpenConsoleDB";
            menuOpenConsoleDB.ShortcutKeys = Keys.Control | Keys.C;
            menuOpenConsoleDB.Size = new Size(285, 26);
            menuOpenConsoleDB.Text = "Open Console DB";
            menuOpenConsoleDB.Click += menuOpenConsoleDB_Click;
            // 
            // menuOpenVIDDB
            // 
            menuOpenVIDDB.Name = "menuOpenVIDDB";
            menuOpenVIDDB.ShortcutKeys = Keys.Control | Keys.V;
            menuOpenVIDDB.Size = new Size(285, 26);
            menuOpenVIDDB.Text = "Open VID DB";
            // 
            // menuSPFile2
            // 
            menuSPFile2.Name = "menuSPFile2";
            menuSPFile2.Size = new Size(282, 6);
            // 
            // menuExportCSVDatabase
            // 
            menuExportCSVDatabase.Name = "menuExportCSVDatabase";
            menuExportCSVDatabase.ShortcutKeys = Keys.Control | Keys.D;
            menuExportCSVDatabase.Size = new Size(285, 26);
            menuExportCSVDatabase.Text = "Export CSV Database";
            menuExportCSVDatabase.Click += menuExportCSVDatabase_Click;
            // 
            // menuCloseDatabase
            // 
            menuCloseDatabase.Name = "menuCloseDatabase";
            menuCloseDatabase.ShortcutKeys = Keys.Control | Keys.X;
            menuCloseDatabase.Size = new Size(285, 26);
            menuCloseDatabase.Text = "Close Database";
            menuCloseDatabase.Click += menuCloseDatabase_Click;
            // 
            // menuSPFile3
            // 
            menuSPFile3.Name = "menuSPFile3";
            menuSPFile3.Size = new Size(282, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Control | Keys.Q;
            menuExit.Size = new Size(285, 26);
            menuExit.Text = "Exit";
            menuExit.Click += menuExit_Click;
            // 
            // menuConfiguration
            // 
            menuConfiguration.DropDownItems.AddRange(new ToolStripItem[] { menuCleanScreen, menuFilterAll, menuGrossEmitter, menuOHIO, menuShowAll, menuSPConfiguration1, menuEditConfigurations });
            menuConfiguration.Name = "menuConfiguration";
            menuConfiguration.Size = new Size(114, 24);
            menuConfiguration.Text = "Configuration";
            menuConfiguration.Visible = false;
            // 
            // menuCleanScreen
            // 
            menuCleanScreen.Name = "menuCleanScreen";
            menuCleanScreen.Size = new Size(219, 26);
            menuCleanScreen.Text = "CleanScreen";
            menuCleanScreen.Click += menuCleanScreen_Click;
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
            grpActiveFilters.Location = new Point(11, 421);
            grpActiveFilters.Name = "grpActiveFilters";
            grpActiveFilters.Size = new Size(178, 288);
            grpActiveFilters.TabIndex = 2;
            grpActiveFilters.TabStop = false;
            grpActiveFilters.Text = "Active-Filters";
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
            // pbxImage
            // 
            pbxImage.BackColor = Color.FromArgb(0, 0, 192);
            pbxImage.Location = new Point(197, 31);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new Size(1147, 703);
            pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImage.TabIndex = 3;
            pbxImage.TabStop = false;
            // 
            // lblNoDatabaseLoaded
            // 
            lblNoDatabaseLoaded.BackColor = Color.FromArgb(0, 0, 192);
            lblNoDatabaseLoaded.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoDatabaseLoaded.ForeColor = Color.White;
            lblNoDatabaseLoaded.Location = new Point(198, 325);
            lblNoDatabaseLoaded.Name = "lblNoDatabaseLoaded";
            lblNoDatabaseLoaded.Size = new Size(1144, 48);
            lblNoDatabaseLoaded.TabIndex = 4;
            lblNoDatabaseLoaded.Text = "NO DATABASE LOADED";
            lblNoDatabaseLoaded.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSelectDatabasefromfilemenu
            // 
            lblSelectDatabasefromfilemenu.BackColor = Color.FromArgb(0, 0, 192);
            lblSelectDatabasefromfilemenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectDatabasefromfilemenu.ForeColor = Color.White;
            lblSelectDatabasefromfilemenu.Location = new Point(198, 405);
            lblSelectDatabasefromfilemenu.Name = "lblSelectDatabasefromfilemenu";
            lblSelectDatabasefromfilemenu.Size = new Size(1144, 48);
            lblSelectDatabasefromfilemenu.TabIndex = 5;
            lblSelectDatabasefromfilemenu.Text = "Select Database from File Menu";
            lblSelectDatabasefromfilemenu.TextAlign = ContentAlignment.TopCenter;
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
            grpSiteData.Location = new Point(11, 217);
            grpSiteData.Name = "grpSiteData";
            grpSiteData.Size = new Size(178, 195);
            grpSiteData.TabIndex = 7;
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
            // lblZoomOut
            // 
            lblZoomOut.ForeColor = Color.Blue;
            lblZoomOut.Location = new Point(955, 772);
            lblZoomOut.Name = "lblZoomOut";
            lblZoomOut.Size = new Size(178, 20);
            lblZoomOut.TabIndex = 8;
            lblZoomOut.Text = "Right Click = Zoom Out";
            lblZoomOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZoomIn
            // 
            lblZoomIn.ForeColor = Color.Blue;
            lblZoomIn.Location = new Point(955, 791);
            lblZoomIn.Name = "lblZoomIn";
            lblZoomIn.Size = new Size(178, 20);
            lblZoomIn.TabIndex = 9;
            lblZoomIn.Text = "Left CLick = Zoom In";
            lblZoomIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShowHotKeys
            // 
            lblShowHotKeys.ForeColor = Color.Blue;
            lblShowHotKeys.Location = new Point(955, 812);
            lblShowHotKeys.Name = "lblShowHotKeys";
            lblShowHotKeys.Size = new Size(178, 20);
            lblShowHotKeys.TabIndex = 10;
            lblShowHotKeys.Text = "F1 - Show Hotkeys";
            lblShowHotKeys.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOptionsGoToVDF
            // 
            btnOptionsGoToVDF.Location = new Point(641, 93);
            btnOptionsGoToVDF.Name = "btnOptionsGoToVDF";
            btnOptionsGoToVDF.Size = new Size(101, 43);
            btnOptionsGoToVDF.TabIndex = 6;
            btnOptionsGoToVDF.Text = "Go To VDF#";
            btnOptionsGoToVDF.UseVisualStyleBackColor = true;
            btnOptionsGoToVDF.Click += btnOptionsGoToVDF_Click;
            // 
            // tbxOptionsGoToVDF
            // 
            tbxOptionsGoToVDF.Location = new Point(641, 61);
            tbxOptionsGoToVDF.Name = "tbxOptionsGoToVDF";
            tbxOptionsGoToVDF.Size = new Size(101, 27);
            tbxOptionsGoToVDF.TabIndex = 5;
            tbxOptionsGoToVDF.TextAlign = HorizontalAlignment.Center;
            tbxOptionsGoToVDF.KeyPress += tbxOptionsGoToVDF_KeyPress;
            // 
            // grpVDF
            // 
            grpVDF.Controls.Add(btnOptionsGoToVDF);
            grpVDF.Controls.Add(tbxOptionsGoToVDF);
            grpVDF.Controls.Add(tbxState);
            grpVDF.Controls.Add(lblVDFPlate);
            grpVDF.Controls.Add(lblVDFUneditedRecords);
            grpVDF.Controls.Add(lblVDFNoofRecords);
            grpVDF.Controls.Add(tbxVDFPlate);
            grpVDF.Controls.Add(btnVDFAccept);
            grpVDF.Location = new Point(197, 745);
            grpVDF.Name = "grpVDF";
            grpVDF.Size = new Size(752, 152);
            grpVDF.TabIndex = 12;
            grpVDF.TabStop = false;
            grpVDF.Text = "VDF 1";
            // 
            // tbxState
            // 
            tbxState.Enabled = false;
            tbxState.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbxState.Location = new Point(185, 91);
            tbxState.MaxLength = 2;
            tbxState.Name = "tbxState";
            tbxState.Size = new Size(60, 43);
            tbxState.TabIndex = 6;
            tbxState.Text = "WB";
            tbxState.KeyPress += tbxState_KeyPress;
            // 
            // lblVDFPlate
            // 
            lblVDFPlate.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblVDFPlate.Location = new Point(185, 49);
            lblVDFPlate.Name = "lblVDFPlate";
            lblVDFPlate.Size = new Size(240, 39);
            lblVDFPlate.TabIndex = 4;
            lblVDFPlate.Text = "Plate";
            lblVDFPlate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVDFUneditedRecords
            // 
            lblVDFUneditedRecords.Location = new Point(459, 27);
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
            tbxVDFPlate.Location = new Point(243, 91);
            tbxVDFPlate.MaxLength = 10;
            tbxVDFPlate.Name = "tbxVDFPlate";
            tbxVDFPlate.Size = new Size(182, 43);
            tbxVDFPlate.TabIndex = 1;
            tbxVDFPlate.KeyPress += tbxVDFPlate_KeyPress;
            // 
            // btnVDFAccept
            // 
            btnVDFAccept.Location = new Point(431, 91);
            btnVDFAccept.Name = "btnVDFAccept";
            btnVDFAccept.Size = new Size(136, 43);
            btnVDFAccept.TabIndex = 0;
            btnVDFAccept.Text = "EDIT (enter)";
            btnVDFAccept.UseVisualStyleBackColor = true;
            btnVDFAccept.Click += btnVDFAccept_Click;
            // 
            // grpRecord
            // 
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
            grpRecord.Location = new Point(1351, 31);
            grpRecord.Name = "grpRecord";
            grpRecord.Size = new Size(178, 624);
            grpRecord.TabIndex = 14;
            grpRecord.TabStop = false;
            grpRecord.Text = "Record";
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
            // tmrTimer
            // 
            tmrTimer.Enabled = true;
            tmrTimer.Interval = 1000;
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // ofdConsoleDB
            // 
            ofdConsoleDB.FileName = "openFileDialog1";
            // 
            // TagEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 916);
            Controls.Add(grpRecord);
            Controls.Add(grpVDF);
            Controls.Add(lblShowHotKeys);
            Controls.Add(lblZoomIn);
            Controls.Add(lblZoomOut);
            Controls.Add(grpSiteData);
            Controls.Add(lblSelectDatabasefromfilemenu);
            Controls.Add(lblNoDatabaseLoaded);
            Controls.Add(pbxImage);
            Controls.Add(grpActiveFilters);
            Controls.Add(grpTagEditor);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "TagEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TagEditor - ETC RSD";
            FormClosing += TagEditor_FormClosing;
            Load += TagEditor_Load;
            KeyDown += TagEditor_KeyDown;
            grpTagEditor.ResumeLayout(false);
            grpTagEditor.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpActiveFilters.ResumeLayout(false);
            grpActiveFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            grpSiteData.ResumeLayout(false);
            grpSiteData.PerformLayout();
            grpVDF.ResumeLayout(false);
            grpVDF.PerformLayout();
            grpRecord.ResumeLayout(false);
            grpRecord.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTagEditor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuLogin;
        private ToolStripSeparator menuSPFile1;
        private ToolStripMenuItem menuOpenLiveDB;
        private ToolStripMenuItem menuConfiguration;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem menuOpenConsoleDB;
        private ToolStripMenuItem menuOpenVIDDB;
        private ToolStripSeparator menuSPFile2;
        private ToolStripMenuItem menuExportCSVDatabase;
        private ToolStripMenuItem menuCloseDatabase;
        private ToolStripSeparator menuSPFile3;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuCleanScreen;
        private ToolStripMenuItem menuFilterAll;
        private ToolStripMenuItem menuGrossEmitter;
        private ToolStripMenuItem menuOHIO;
        private ToolStripMenuItem menuShowAll;
        private ToolStripSeparator menuSPConfiguration1;
        private ToolStripMenuItem menuEditConfigurations;
        private ToolStripMenuItem menuAbout;
        private TextBox tbxTagEditTime;
        private Label lblTagEditTime;
        private TextBox tbxTagEditDate;
        private Label lblTagEditDate;
        private TextBox tbxTagEditUser;
        private GroupBox grpActiveFilters;
        private TextBox tbxActiveFiltersVSP;
        private TextBox tbxActiveFiltersCVA;
        private TextBox tbxActiveFiltersGas;
        private TextBox tbxActiveFiltersSnA;
        private TextBox tbxActiveFiltersCleanScreen;
        private TextBox tbxActiveFiltersALPR;
        private TextBox tbxActiveFiltersAccel;
        private TextBox tbxActiveFiltersSpeed;
        private PictureBox pbxImage;
        private Label lblNoDatabaseLoaded;
        private Label lblSelectDatabasefromfilemenu;
        private GroupBox grpSiteData;
        private TextBox tbxSiteDataSlope;
        private Label lblSiteDataSlope;
        private TextBox tbxSiteDataOperator;
        private Label lblSiteDataOperator;
        private TextBox tbxSiteDataSiteCode;
        private Label lblSiteDataSiteCode;
        private Label lblZoomOut;
        private Label lblZoomIn;
        private Label lblShowHotKeys;
        private Button btnOptionsGoToVDF;
        private TextBox tbxOptionsGoToVDF;
        private GroupBox grpVDF;
        private TextBox tbxVDFPlate;
        private Button btnVDFAccept;
        private Label lblVDFPlate;
        private Label lblVDFUneditedRecords;
        private Label lblVDFNoofRecords;
        private GroupBox grpRecord;
        private Label lblRecordTime;
        private TextBox tbxRecordSpeed;
        private Label lblRecordSpeed;
        private TextBox tbxRecordCVAStatus;
        private Label lblRecordCVAStatus;
        private TextBox tbxRecordTime;
        private Label lblRecordCO2max;
        private TextBox tbxRecorduvSmoke;
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
        private Label lblActiveFilters;
        private System.Windows.Forms.Timer tmrTimer;
        private OpenFileDialog ofdConsoleDB;
        private TextBox tbxState;
    }
}
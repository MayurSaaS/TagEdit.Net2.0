namespace TagEdit.Net
{
    partial class frmLogin
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
            btnLogin = new Button();
            lblUserName = new Label();
            pbxLogin = new PictureBox();
            tbxUserName = new TextBox();
            rdbNormalTagEdit = new RadioButton();
            rdbAuditTagEdit = new RadioButton();
            cbxStateCode = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxLogin).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(334, 164);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 60);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(215, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(260, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // pbxLogin
            // 
            pbxLogin.Image = Properties.Resources.TagEdit_New;
            pbxLogin.Location = new Point(35, 2);
            pbxLogin.Name = "pbxLogin";
            pbxLogin.Size = new Size(157, 143);
            pbxLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxLogin.TabIndex = 2;
            pbxLogin.TabStop = false;
            // 
            // tbxUserName
            // 
            tbxUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUserName.Location = new Point(215, 35);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(260, 34);
            tbxUserName.TabIndex = 3;
            tbxUserName.Text = "Atanu";
            // 
            // rdbNormalTagEdit
            // 
            rdbNormalTagEdit.Checked = true;
            rdbNormalTagEdit.Location = new Point(35, 164);
            rdbNormalTagEdit.Name = "rdbNormalTagEdit";
            rdbNormalTagEdit.Size = new Size(135, 30);
            rdbNormalTagEdit.TabIndex = 4;
            rdbNormalTagEdit.TabStop = true;
            rdbNormalTagEdit.Text = "Normal TagEdit";
            rdbNormalTagEdit.UseVisualStyleBackColor = true;
            // 
            // rdbAuditTagEdit
            // 
            rdbAuditTagEdit.Enabled = false;
            rdbAuditTagEdit.Location = new Point(35, 194);
            rdbAuditTagEdit.Name = "rdbAuditTagEdit";
            rdbAuditTagEdit.Size = new Size(128, 30);
            rdbAuditTagEdit.TabIndex = 5;
            rdbAuditTagEdit.Text = "Audit TagEdit";
            rdbAuditTagEdit.UseVisualStyleBackColor = true;
            // 
            // cbxStateCode
            // 
            cbxStateCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStateCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbxStateCode.FormattingEnabled = true;
            cbxStateCode.Location = new Point(215, 112);
            cbxStateCode.Name = "cbxStateCode";
            cbxStateCode.Size = new Size(98, 33);
            cbxStateCode.TabIndex = 8;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 87);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 9;
            label1.Text = "State RTO Code";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 236);
            Controls.Add(label1);
            Controls.Add(cbxStateCode);
            Controls.Add(rdbAuditTagEdit);
            Controls.Add(rdbNormalTagEdit);
            Controls.Add(tbxUserName);
            Controls.Add(pbxLogin);
            Controls.Add(lblUserName);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TagEdit.Net  -  Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUserName;
        private PictureBox pbxLogin;
        private TextBox tbxUserName;
        private RadioButton rdbNormalTagEdit;
        private RadioButton rdbAuditTagEdit;
        private ComboBox cbxStateCode;
        private Label label1;
    }
}
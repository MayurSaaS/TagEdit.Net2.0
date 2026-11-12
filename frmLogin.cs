using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagEdit.Net
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " - " + Program.MachineName + " - Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUserName.Text))
            {
                Program.strUserName = tbxUserName.Text;
                Program.StateRTOCode = cbxStateCode.Text;
                this.Close();
            }
            else
            {
                Program.strUserName = string.Empty;
                MessageBox.Show("You must Log in with your name to use the TagEdit.Net", "TagEdit.Net  -  Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbxStateCode.DataSource = Properties.Settings.Default.StateCode;
        }
    }//Class
}//Namespace

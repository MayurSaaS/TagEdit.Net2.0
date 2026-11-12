using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TagEdit.Net
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        public static string strUserName = string.Empty;
        public static bool blnDatabase = false;
        //public static string TagEdit_Title = "ETC RSD"; // ETC RSD, OPUS RSD
        public static string MachineName = Properties.Settings.Default.MachineName;
        public static string StateRTOCode = string.Empty;
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
            if (!string.IsNullOrEmpty(strUserName)) 
            {
                if (MachineName.StartsWith("ETC"))
                    Application.Run(new TagEditor());
                else if (MachineName.ToUpper().StartsWith("ESP OPUS 2.0"))
                    Application.Run(new TagEditor_OPUS());

            }
        }
    }
}
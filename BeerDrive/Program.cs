using BeerDrive.DAL.Exceptions;
using BeerDrive.UI.Forms;
using DevExpress.XtraEditors;
using System;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace BeerDrive
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result;

            using (var loginForm = new LoginForm())
            {
                result = loginForm.ShowDialog();
            }

            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string message;

            if (e.Exception is FaultException<AccessFault>)
            {
                message = (e.Exception as FaultException<AccessFault>).Detail.Message;
            }
            else if (e.Exception is FaultException<ValidationFault>)
            {
                message = (e.Exception as FaultException<ValidationFault>).Detail.Message;
            }
            else
            {
                message = e.Exception.ToString();
            }

            XtraMessageBox.Show(message, "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }
    }
}

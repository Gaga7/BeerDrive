using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace BeerDrive.Helpers
{
    public static class BarcodeScannerHelper
    {
        public static bool IsScannerPrefix(Keys keyData)
        {
            var key = keyData & Keys.KeyCode;
            return key == Keys.F9 || key == Keys.F12;
        }

        public static void PrepareForScan(Control targetControl)
        {
            if (targetControl == null)
                return;

            targetControl.Focus();

            if (targetControl is TextEdit textEdit)
            {
                textEdit.Text = string.Empty;
            }
            else
            {
                targetControl.Text = string.Empty;
            }
        }
    }
}

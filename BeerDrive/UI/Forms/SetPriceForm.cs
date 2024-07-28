using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class SetPriceForm : XtraForm
    {
        public decimal UnitPrice
        {
            get { return UnitPriceSpn.Value; }
        }

        public SetPriceForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UnitPrice == 0)
            {
                XtraMessageBox.Show("ფასი ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

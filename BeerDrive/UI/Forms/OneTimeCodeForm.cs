using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class OneTimeCodeForm : XtraForm
    {
        private TransactionDetailPresenter transactionDetailPresenter;

        public TransactionDetailPresenter TransactionDetailPresenter
        {
            get
            {
                if (transactionDetailPresenter == null)
                    transactionDetailPresenter = new TransactionDetailPresenter();

                return transactionDetailPresenter;
            }
        }

        private readonly Guid _id;

        public string Code
        {
            get { return CodeTxt.Text; }
        }

        public OneTimeCodeForm(Guid id)
        {
            InitializeComponent();

            _id = id;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(Code) || Code.Contains("_"))
            {
                XtraMessageBox.Show("კოდი ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var entity = await TransactionDetailPresenter.GetAsync(_id);

            if (string.IsNullOrEmpty(entity.Code))
            {
                XtraMessageBox.Show("ერთჯერადი კოდი არ არის გაგზავნილი მიმღებთან", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (entity.Code != Code)
            {
                XtraMessageBox.Show("კოდი არასწორია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void closeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

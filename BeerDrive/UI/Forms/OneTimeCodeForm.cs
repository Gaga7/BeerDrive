using BeerDrive.DAL.Enums;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class OneTimeCodeForm : XtraForm
    {
        private TransactionDetailPresenter transactionDetailPresenter;
        private TransactionPresenter transactionPresenter;

        public TransactionDetailPresenter TransactionDetailPresenter
        {
            get
            {
                if (transactionDetailPresenter == null)
                    transactionDetailPresenter = new TransactionDetailPresenter();

                return transactionDetailPresenter;
            }
        }

        public TransactionPresenter TransactionPresenter
        {
            get
            {
                if (transactionPresenter == null)
                    transactionPresenter = new TransactionPresenter();

                return transactionPresenter;
            }
        }

        private readonly Guid _id;
        private readonly OneTimeCodeTypesEnum _type;

        public string Code
        {
            get { return CodeTxt.Text; }
        }

        public OneTimeCodeForm(Guid id, OneTimeCodeTypesEnum type)
        {
            InitializeComponent();

            _id = id;
            _type = type;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(Code) || Code.Contains("_"))
            {
                XtraMessageBox.Show("კოდი ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var code = string.Empty;

            if (_type == OneTimeCodeTypesEnum.TransactionDetail)
            {
                var entity = await TransactionDetailPresenter.GetAsync(_id);

                code = entity.Code;
            }
            else if (_type == OneTimeCodeTypesEnum.Transaction)
            {
                var entity = await TransactionPresenter.GetAsync(_id);

                code = entity.Code;
            }

            if (string.IsNullOrEmpty(code))
            {
                XtraMessageBox.Show("ერთჯერადი კოდი არ არის გაგზავნილი მიმღებთან", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (code != Code)
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

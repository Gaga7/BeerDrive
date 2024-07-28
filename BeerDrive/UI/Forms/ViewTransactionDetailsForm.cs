using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;

namespace BeerDrive.UI.Forms
{
    public partial class ViewTransactionDetailsForm : XtraForm
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

        private readonly Guid _transactionId;

        public ViewTransactionDetailsForm()
        {
            InitializeComponent();
        }

        public ViewTransactionDetailsForm(Guid id) : this()
        {
            _transactionId = id;
        }

        private async void ViewTransactionDetailsForm_Load(object sender, EventArgs e)
        {
            await BindTransactionDetails();
        }

        private async Task BindTransactionDetails()
        {
            getTransactionDetailDtoBindingSource.DataSource = await TransactionDetailPresenter.GetAsync(c => c.TransactionId == _transactionId);
        }
    }
}

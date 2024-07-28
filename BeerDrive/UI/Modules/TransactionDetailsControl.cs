using BeerDrive.Presenters;
using DevExpress.DXperience.Demos;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Threading.Tasks;

namespace BeerDrive.UI.Modules
{
    public partial class TransactionDetailsControl : TutorialControlBase
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

        private int days = 3;

        public TransactionDetailsControl()
        {
            InitializeComponent();
        }

        private async void TransactionDetailsControl_Load(object sender, EventArgs e)
        {
            await BindTransactioDetails();
        }

        private async Task BindTransactioDetails()
        {
            var daysText = ConfigurationManager.AppSettings["Days"];

            if (!string.IsNullOrEmpty(daysText))
            {
                if (Convert.ToInt32(daysText) > 0)
                    days = Convert.ToInt32(daysText);
            }

            var fromDate = DateTime.Now.Date.AddDays(-days);

            getTransactionDetailDtoBindingSource.DataSource = await TransactionDetailPresenter.GetAsync(r => DbFunctions.TruncateTime(r.DateCreated) > fromDate.Date);
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindTransactioDetails();
        }
    }
}

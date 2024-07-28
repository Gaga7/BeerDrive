using BeerDrive.DTOs;
using BeerDrive.Presenters;
using BeerDrive.UI.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Modules
{
    public partial class TransactionControl : TutorialControlBase
    {
        private TransactionPresenter transactionPresenter;
        public TransactionPresenter TransactionPresenter
        {
            get
            {
                if (transactionPresenter == null)
                    transactionPresenter = new TransactionPresenter();

                return transactionPresenter;
            }
        }

        private int days = 3;

        public TransactionControl()
        {
            InitializeComponent();
        }

        private async void TransactionControl_Load(object sender, EventArgs e)
        {
            await BindTransactions();
        }

        private async Task BindTransactions()
        {
            var daysText = ConfigurationManager.AppSettings["Days"];

            if (!string.IsNullOrEmpty(daysText))
            {
                if (Convert.ToInt32(daysText) > 0)
                    days = Convert.ToInt32(daysText);
            }

            var fromDate = DateTime.Now.Date.AddDays(-days);

            getTransactionDtoBindingSource.DataSource = await TransactionPresenter.GetAsync(r => DbFunctions.TruncateTime(r.DateCreated) > fromDate.Date);
        }

        private async void ViewDetailsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)transactionsGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetTransactionDto)((GridView)transactionsGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await TransactionPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new ViewTransactionDetailsForm(selectedRow.Id);
            form.ShowDialog();
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindTransactions();
        }
    }
}

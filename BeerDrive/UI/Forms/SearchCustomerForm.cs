using BeerDrive.DAL.Enums;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class SearchCustomerForm : XtraForm
    {
        private CustomerPresenter customerPresenter;
        private ExchangeRatePresenter exchangeRatePresenter;

        public CustomerPresenter CustomerPresenter
        {
            get
            {
                if (customerPresenter == null)
                    customerPresenter = new CustomerPresenter();

                return customerPresenter;
            }
        }

        public ExchangeRatePresenter ExchangeRatePresenter
        {
            get
            {
                if (exchangeRatePresenter == null)
                    exchangeRatePresenter = new ExchangeRatePresenter();

                return exchangeRatePresenter;
            }
        }

        public Guid? CustomerId;

        private string Mobile
        {
            get { return MobileTxt.Text; }
            set { MobileTxt.Text = value; }
        }

        public string Customer
        {
            get { return CustomerTxt.Text; }
            set { CustomerTxt.Text = value; }
        }

        private decimal Score
        {
            get { return ScoreSpn.Value; }
            set { ScoreSpn.Value = value; }
        }

        private decimal Amount
        {
            get { return AmountSpn.Value; }
            set { AmountSpn.Value = value; }
        }

        public SearchCustomerForm()
        {
            InitializeComponent();
        }

        private async void SearchBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await Search();
        }

        private async void AddBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddOrUpdateCustomerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mobile = form.Mobile;

                await Search();
            }
        }

        private void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomerId = null;

            Close();
        }

        private async void MobileTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            await Search();
        }

        private async Task Search()
        {
            var entities = await CustomerPresenter.GetAsync(r => r.Mobile == Mobile);
            var entity = entities.FirstOrDefault();

            if (entity == null)
            {
                XtraMessageBox.Show("კლიენტი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rate = (await ExchangeRatePresenter.GetAsync(r => r.ExchangeTypeId == ExchangeTypesEnum.Buy)).FirstOrDefault();

            if (rate == null)
            {
                XtraMessageBox.Show("კურსი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerId = entity.Id;
            Customer = $"{entity.FirstName} {entity.LastName}";
            Score = entity.Score;
            Amount = Math.Round(entity.Score / rate.Score * rate.Amount, 4);
        }
    }
}

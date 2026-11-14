using BeerDrive.DTOs;
using BeerDrive.Presenters;
using BeerDrive.UI.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Modules
{
    public partial class ExchangeRatesControl : TutorialControlBase
    {
        private ExchangeRatePresenter exchangeRatePresenter;
        public ExchangeRatePresenter ExchangeRatePresenter
        {
            get
            {
                if (exchangeRatePresenter == null)
                    exchangeRatePresenter = new ExchangeRatePresenter();

                return exchangeRatePresenter;
            }
        }

        public ExchangeRatesControl()
        {
            InitializeComponent();
        }

        private async void ExchangeRatesGridview_Load(object sender, System.EventArgs e)
        {
            await BindExchangeRates();
        }

        private async Task BindExchangeRates()
        {
            getExchangeRateDtoBindingSource.DataSource = await ExchangeRatePresenter.GetAsync();
        }

        private async void AddExchangeRateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddOrUpdateExchangeRateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindExchangeRates();
            }
        }

        private async void EditExchangeRateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)exchangeRatesGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetExchangeRateDto)((GridView)exchangeRatesGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await ExchangeRatePresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AddOrUpdateExchangeRateForm(selectedRow.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindExchangeRates();
            }
        }

        private async void DeleteExchangeRateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)exchangeRatesGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetCategoryDto)((GridView)exchangeRatesGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await ExchangeRatePresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის წაშლა?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await ExchangeRatePresenter.DeleteAsync(selectedRow.Id);

                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindExchangeRates();
            }
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindExchangeRates();
        }
    }
}

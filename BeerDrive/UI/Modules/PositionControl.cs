using BeerDrive.DTOs;
using BeerDrive.Presenters;
using BeerDrive.UI.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Modules
{
    public partial class PositionControl : TutorialControlBase
    {
        private PositionPresenter positionPresenter;
        public PositionPresenter PositionPresenter
        {
            get
            {
                if (positionPresenter == null)
                    positionPresenter = new PositionPresenter();

                return positionPresenter;
            }
        }

        public PositionControl()
        {
            InitializeComponent();
        }

        private async void PositionControl_Load(object sender, EventArgs e)
        {
            await BindPositions();
        }

        private async Task BindPositions()
        {
            getPositionDtoBindingSource.DataSource = await PositionPresenter.GetAsync();
        }

        private async void AddBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddOrUpdatePositionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindPositions();
            }
        }

        private async void EditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)positionsGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetPositionDto)((GridView)positionsGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await PositionPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AddOrUpdatePositionForm(selectedRow.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindPositions();
            }
        }

        private async void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)positionsGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetPositionDto)((GridView)positionsGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await PositionPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის წაშლა?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await PositionPresenter.DeleteAsync(selectedRow.Id);

                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindPositions();
            }
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindPositions();
        }
    }
}

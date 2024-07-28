using BeerDrive.DTOs;
using BeerDrive.Presenters;
using BeerDrive.UI.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Modules
{
    public partial class CategoryControl : TutorialControlBase
    {
        private CategoryPresenter categoryPresenter;
        public CategoryPresenter CategoryPresenter
        {
            get
            {
                if (categoryPresenter == null)
                    categoryPresenter = new CategoryPresenter();

                return categoryPresenter;
            }
        }

        private ProductPresenter productPresenter;
        public ProductPresenter ProductPresenter
        {
            get
            {
                if (productPresenter == null)
                    productPresenter = new ProductPresenter();

                return productPresenter;
            }
        }

        public CategoryControl()
        {
            InitializeComponent();
        }

        private async void CategoriesGridview_Load(object sender, EventArgs e)
        {
            await BindCategories();
        }

        private async Task BindCategories()
        {
            getCategoryDtoBindingSource.DataSource = await CategoryPresenter.GetAsync();
        }

        private async void AddCategoryBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new AddOrUpdateCategoryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindCategories();
            }
        }

        private async void EditCategoryBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selected = ((GridView)categoriesGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetCategoryDto)((GridView)categoriesGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await CategoryPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AddOrUpdateCategoryForm(selectedRow.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindCategories();
            }
        }

        private async void DeleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selected = ((GridView)categoriesGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetCategoryDto)((GridView)categoriesGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await CategoryPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის წაშლა?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await CategoryPresenter.DeleteAsync(selectedRow.Id);

                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindCategories();
            }
        }

        private async void RefreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            await BindCategories();
        }
    }
}

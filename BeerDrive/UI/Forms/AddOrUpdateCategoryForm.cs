using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateCategoryForm : XtraForm
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

        private readonly Guid? _id;

        public string CategoryName
        {
            get => NameTxt.Text;
            private set => NameTxt.Text = value;
        }

        public string Description
        {
            get => DescriptionTxt.Text;
            private set => DescriptionTxt.Text = value;
        }

        public AddOrUpdateCategoryForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateCategoryForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdateCategoryForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private async void Fill()
        {
            if (_id == null)
                return;

            var entity = await CategoryPresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            CategoryName = entity.Name;
            Description = entity.Description;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetCategoryDto()
            {
                Name = CategoryName,
                Description = Description
            };

            if (_id == null)
                await CategoryPresenter.CreateAsync(model);
            else
                await CategoryPresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

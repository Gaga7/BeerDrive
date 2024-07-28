using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdatePositionForm : XtraForm
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

        private readonly Guid? _id;

        public string PositionName
        {
            get => NameTxt.Text;
            private set => NameTxt.Text = value;
        }

        public AddOrUpdatePositionForm()
        {
            InitializeComponent();
        }

        public AddOrUpdatePositionForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdatePositionForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private async void Fill()
        {
            if (_id == null)
                return;

            var entity = await PositionPresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            PositionName = entity.Name;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetPositionDto()
            {
                Name = PositionName,
            };

            if (_id == null)
                await PositionPresenter.CreateAsync(model);
            else
                await PositionPresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
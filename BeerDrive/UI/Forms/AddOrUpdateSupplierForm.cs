using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateSupplierForm : XtraForm
    {
        private SupplierPresenter supplierPresenter;
        private MobileIndexPresenter mobileIndexPresenter;

        public SupplierPresenter SupplierPresenter
        {
            get
            {
                if (supplierPresenter == null)
                    supplierPresenter = new SupplierPresenter();

                return supplierPresenter;
            }
        }

        public MobileIndexPresenter MobileIndexPresenter
        {
            get
            {
                if (mobileIndexPresenter == null)
                    mobileIndexPresenter = new MobileIndexPresenter();

                return mobileIndexPresenter;
            }
        }

        private readonly Guid? _id;

        public string SupplierName
        {
            get => NameTxt.Text;
            private set => NameTxt.Text = value;
        }

        public string ContactFirstName
        {
            get => ContactFirstNameTxt.Text;
            private set => ContactFirstNameTxt.Text = value;
        }

        public string ContactLastName
        {
            get => ContactLastNameTxt.Text;
            private set => ContactLastNameTxt.Text = value;
        }

        public Guid? MobileIndexId
        {
            get
            {
                var selected = MobileIndexIdCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set => SetValue(MobileIndexIdCmb, value);
        }

        public string Mobile
        {
            get => MobileTxt.Text;
            private set => MobileTxt.Text = value;
        }

        public AddOrUpdateSupplierForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateSupplierForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdateSupplierForm_Load(object sender, EventArgs e)
        {
            FillMobileIndexes();
            Fill();
        }

        private void SetValue(ComboBoxEdit control, Guid? value)
        {
            foreach (ImageListBoxItem item in control.Properties.Items)
            {
                if ((Guid?)item.Value == value)
                {
                    control.SelectedItem = item;
                    return;
                }
            }
        }

        private async void FillMobileIndexes()
        {
            var mobileIndexes = await MobileIndexPresenter.GetAsync();
            var datasource = mobileIndexes.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            MobileIndexIdCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            MobileIndexIdCmb.Properties.Items.AddRange(datasource);

            MobileIndexIdCmb.SelectedIndex = 0;
        }

        private async void Fill()
        {
            if (_id == null)
                return;

            var entity = await SupplierPresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            SupplierName = entity.Name;
            ContactFirstName = entity.FirstName;
            ContactLastName = entity.LastName;
            MobileIndexId = entity.MobileIndexId;
            Mobile = entity.Mobile;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetSupplierDto()
            {
                Name = SupplierName,
                FirstName = ContactFirstName,
                LastName = ContactLastName,
                MobileIndexId = MobileIndexId,
                Mobile = Mobile
            };

            if (_id == null)
                await SupplierPresenter.CreateAsync(model);
            else
                await SupplierPresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

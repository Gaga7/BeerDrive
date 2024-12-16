using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;
using System.Linq;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateCustomerForm : XtraForm
    {
        private CustomerPresenter customerPresenter;
        private MobileIndexPresenter mobileIndexPresenter;

        public CustomerPresenter CustomerPresenter
        {
            get
            {
                if (customerPresenter == null)
                    customerPresenter = new CustomerPresenter();

                return customerPresenter;
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

        public string FirstName
        {
            get => FirstNameTxt.Text;
            private set => FirstNameTxt.Text = value;
        }

        public string LastName
        {
            get => LastNameTxt.Text;
            private set => LastNameTxt.Text = value;
        }

        public string Mobile
        {
            get => MobileTxt.Text;
            private set => MobileTxt.Text = value;
        }

        public AddOrUpdateCustomerForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateCustomerForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdateCustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomer();
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

        private async void FillCustomer()
        {
            if (_id == null)
                return;

            var entity = await CustomerPresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            FirstName = entity.FirstName;
            LastName = entity.LastName;
            Mobile = entity.Mobile;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetCustomerDto()
            {
                FirstName = FirstName,
                LastName = LastName,
                Mobile = Mobile
            };

            if (_id == null)
                await CustomerPresenter.CreateAsync(model);
            else
                await CustomerPresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

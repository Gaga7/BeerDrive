using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateRoleForm : XtraForm
    {
        private RolePresenter rolePresenter;

        public RolePresenter RolePresenter
        {
            get
            {
                if (rolePresenter == null)
                    rolePresenter = new RolePresenter();

                return rolePresenter;
            }
        }

        private readonly Guid? _id;

        public string RoleName
        {
            get => NameTxt.Text;
            private set => NameTxt.Text = value;
        }

        public AddOrUpdateRoleForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateRoleForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdateRoleForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private async void Fill()
        {
            if (_id == null)
                return;

            var entity = await RolePresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            RoleName = entity.Name;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetRoleDto()
            {
                Name = RoleName,
            };

            if (_id == null)
                await RolePresenter.CreateAsync(model);
            else
                await RolePresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }


    }
}
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
    public partial class RoleControl : TutorialControlBase
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

        public RoleControl()
        {
            InitializeComponent();
        }

        private async void RoleControl_Load(object sender, EventArgs e)
        {
            await BindRoles();
        }

        private async Task BindRoles()
        {
            getRoleDtoBindingSource.DataSource = await RolePresenter.GetAsync();
        }

        private async void AddBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddOrUpdateRoleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindRoles();
            }
        }

        private async void EditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)rolesGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetRoleDto)((GridView)rolesGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await RolePresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AddOrUpdateRoleForm(selectedRow.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindRoles();
            }
        }

        private async void DeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)rolesGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetRoleDto)((GridView)rolesGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await RolePresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის წაშლა?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await RolePresenter.DeleteAsync(selectedRow.Id);

                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindRoles();
            }
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindRoles();
        }
    }
}

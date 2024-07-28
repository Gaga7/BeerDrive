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
    public partial class UserControl : TutorialControlBase
    {
        private UserPresenter userPresenter;
        public UserPresenter UserPresenter
        {
            get
            {
                if (userPresenter == null)
                    userPresenter = new UserPresenter();

                return userPresenter;
            }
        }

        public UserControl()
        {
            InitializeComponent();
        }

        private async void UsersGridview_Load(object sender, EventArgs e)
        {
            await BindUsers();
        }

        private async Task BindUsers()
        {
            userDtoBindingSource.DataSource = await UserPresenter.GetAsync();
        }

        private async void AddUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AddOrUpdateUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindUsers();
            }
        }

        private async void EditUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)usersGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetUserDto)((GridView)usersGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await UserPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AddOrUpdateUserForm(selectedRow.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindUsers();
            }
        }

        private async void DeleteUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = ((GridView)usersGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetUserDto)((GridView)usersGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await UserPresenter.CheckAsync(selectedRow.Id))
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის წაშლა?", "შეტყობინება", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await UserPresenter.DeleteAsync(selectedRow.Id);

                XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await BindUsers();
            }
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindUsers();
        }
    }
}

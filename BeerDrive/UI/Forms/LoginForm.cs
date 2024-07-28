using BeerDrive.DAL.ViewEntities;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using BeerDrive.Global;

namespace BeerDrive.UI.Forms
{
    public partial class LoginForm : XtraForm
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

        public string LoginName
        {
            get { return loginNameTxt.Text; }
            set { loginNameTxt.Text = value; }
        }

        public string Password
        {
            get { return passwordTxt.Text; }
            set { passwordTxt.Text = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var header = new AuthHeader
            {
                LoginName = LoginName,
                Password = Password,
                Culture = Globals.Culture,
                Version = Globals.CurrentVersion
            };

            Globals.User = await UserPresenter.LoginAsync(header);
            Globals.AuthHeader = header;

            DialogResult = DialogResult.OK;

            Cursor.Current = Cursors.Default;
        }
    }
}

using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateUserForm : XtraForm
    {
        private PositionPresenter positionPresenter;
        private RolePresenter rolePresenter;
        private UserPresenter userPresenter;

        public PositionPresenter PositionPresenter
        {
            get
            {
                if (positionPresenter == null)
                    positionPresenter = new PositionPresenter();

                return positionPresenter;
            }
        }

        public RolePresenter RolePresenter
        {
            get
            {
                if (rolePresenter == null)
                    rolePresenter = new RolePresenter();

                return rolePresenter;
            }
        }

        public UserPresenter UserPresenter
        {
            get
            {
                if (userPresenter == null)
                    userPresenter = new UserPresenter();

                return userPresenter;
            }
        }

        private readonly Guid? _id;

        public string PersonalId
        {
            get { return PersonalIdTxt.Text; }
            set { PersonalIdTxt.Text = value; }
        }

        public string FirstName
        {
            get { return FirstNameTxt.Text; }
            set { FirstNameTxt.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTxt.Text; }
            set { LastNameTxt.Text = value; }
        }

        public string LoginName
        {
            get { return LoginNameTxt.Text; }
            set { LoginNameTxt.Text = value; }
        }

        public string Password
        {
            get { return PasswordTxt.Text; }
            set { PasswordTxt.Text = value; }
        }

        public Guid? PositionId
        {
            get
            {
                var selected = PositionCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set
            {
                SetValue(PositionCmb, value);
            }
        }

        public bool Status
        {
            get { return StatusCheckEdit.Checked; }
            set { StatusCheckEdit.Checked = value; }
        }

        public List<Guid> RoleIds
        {
            get
            {
                var checkedValues = RoleCheckedCmb.Properties.Items.GetCheckedValues();
                return checkedValues.Select(s => Guid.Parse(s.ToString())).ToList();
            }
            private set
            {
                foreach (CheckedListBoxItem item in RoleCheckedCmb.Properties.Items)
                {
                    if (value != null && value.Any(a => a == Guid.Parse(item.Value.ToString())))
                        item.CheckState = CheckState.Checked;
                    else
                        item.CheckState = CheckState.Unchecked;
                }
            }
        }

        public bool PasswordVisible
        {
            get { return ItemForPassword.ContentVisible; }
            set { ItemForPassword.ContentVisible = value; }
        }

        public AddOrUpdateUserForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateUserForm(Guid id) : this()
        {
            _id = id;

            PasswordVisible = false;
        }

        private void AddOrUpdateUserForm_Load(object sender, EventArgs e)
        {
            FillPositions();
            FillRoles();
            Fill();
        }

        private async void Fill()
        {
            if (_id == null)
                return;

            var entity = await UserPresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            PersonalId = entity.PersonalId;
            FirstName = entity.FirstName;
            LastName = entity.LastName;
            LoginName = entity.LoginName;
            PositionId = entity.PositionId;
            Status = entity.Status;
            RoleIds = entity.RoleIds;
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

        private async void FillPositions()
        {
            var positions = await PositionPresenter.GetAsync();
            var datasource = positions.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            PositionCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            PositionCmb.Properties.Items.AddRange(datasource);

            PositionCmb.SelectedIndex = 0;
        }

        private async void FillRoles()
        {
            var roles = await RolePresenter.GetAsync();
            var datasource = roles.Select(s => new CheckedListBoxItem(s.Id, s.Name)).ToArray();

            RoleCheckedCmb.Properties.Items.AddRange(datasource);
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetUserDto
            {
                PersonalId = PersonalId,
                FirstName = FirstName,
                LastName = LastName,
                LoginName = LoginName,
                Password = Password,
                PositionId = PositionId,
                Status = Status,
                RoleIds = RoleIds
            };

            if (_id == null)
                await UserPresenter.CreateAsync(model);
            else
                await UserPresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CloseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

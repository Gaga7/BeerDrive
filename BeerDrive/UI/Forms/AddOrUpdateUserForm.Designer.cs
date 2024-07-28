
namespace BeerDrive.UI.Forms
{
    partial class AddOrUpdateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateUserForm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.RoleCheckedCmb = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.PersonalIdTxt = new DevExpress.XtraEditors.TextEdit();
            this.setUserDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.LastNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.LoginNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTxt = new DevExpress.XtraEditors.TextEdit();
            this.StatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.PositionCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPersonalId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLoginName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPositionId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.closeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleCheckedCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalIdTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setUserDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPersonalId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLoginName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPositionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.RoleCheckedCmb);
            this.dataLayoutControl1.Controls.Add(this.PersonalIdTxt);
            this.dataLayoutControl1.Controls.Add(this.FirstNameTxt);
            this.dataLayoutControl1.Controls.Add(this.LastNameTxt);
            this.dataLayoutControl1.Controls.Add(this.LoginNameTxt);
            this.dataLayoutControl1.Controls.Add(this.PasswordTxt);
            this.dataLayoutControl1.Controls.Add(this.StatusCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.PositionCmb);
            this.dataLayoutControl1.DataSource = this.setUserDtoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(440, 258);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // RoleCheckedCmb
            // 
            this.RoleCheckedCmb.Location = new System.Drawing.Point(110, 196);
            this.RoleCheckedCmb.Name = "RoleCheckedCmb";
            this.RoleCheckedCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RoleCheckedCmb.Size = new System.Drawing.Size(318, 22);
            this.RoleCheckedCmb.StyleController = this.dataLayoutControl1;
            this.RoleCheckedCmb.TabIndex = 12;
            // 
            // PersonalIdTxt
            // 
            this.PersonalIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "PersonalId", true));
            this.PersonalIdTxt.Location = new System.Drawing.Point(110, 12);
            this.PersonalIdTxt.Name = "PersonalIdTxt";
            this.PersonalIdTxt.Size = new System.Drawing.Size(318, 22);
            this.PersonalIdTxt.StyleController = this.dataLayoutControl1;
            this.PersonalIdTxt.TabIndex = 4;
            // 
            // setUserDtoBindingSource
            // 
            this.setUserDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.SetUserDto);
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "FirstName", true));
            this.FirstNameTxt.Location = new System.Drawing.Point(110, 38);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(318, 22);
            this.FirstNameTxt.StyleController = this.dataLayoutControl1;
            this.FirstNameTxt.TabIndex = 5;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "LastName", true));
            this.LastNameTxt.Location = new System.Drawing.Point(110, 64);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(318, 22);
            this.LastNameTxt.StyleController = this.dataLayoutControl1;
            this.LastNameTxt.TabIndex = 6;
            // 
            // LoginNameTxt
            // 
            this.LoginNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "LoginName", true));
            this.LoginNameTxt.Location = new System.Drawing.Point(110, 90);
            this.LoginNameTxt.Name = "LoginNameTxt";
            this.LoginNameTxt.Size = new System.Drawing.Size(318, 22);
            this.LoginNameTxt.StyleController = this.dataLayoutControl1;
            this.LoginNameTxt.TabIndex = 7;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "Password", true));
            this.PasswordTxt.Location = new System.Drawing.Point(110, 116);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Properties.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(318, 22);
            this.PasswordTxt.StyleController = this.dataLayoutControl1;
            this.PasswordTxt.TabIndex = 8;
            // 
            // StatusCheckEdit
            // 
            this.StatusCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "Status", true));
            this.StatusCheckEdit.Location = new System.Drawing.Point(12, 168);
            this.StatusCheckEdit.Name = "StatusCheckEdit";
            this.StatusCheckEdit.Properties.Caption = "სტატუსი";
            this.StatusCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.StatusCheckEdit.Size = new System.Drawing.Size(416, 24);
            this.StatusCheckEdit.StyleController = this.dataLayoutControl1;
            this.StatusCheckEdit.TabIndex = 10;
            // 
            // PositionCmb
            // 
            this.PositionCmb.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setUserDtoBindingSource, "PositionId", true));
            this.PositionCmb.Location = new System.Drawing.Point(110, 142);
            this.PositionCmb.Name = "PositionCmb";
            this.PositionCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PositionCmb.Size = new System.Drawing.Size(318, 22);
            this.PositionCmb.StyleController = this.dataLayoutControl1;
            this.PositionCmb.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(440, 258);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPersonalId,
            this.ItemForFirstName,
            this.ItemForLastName,
            this.ItemForLoginName,
            this.ItemForPassword,
            this.ItemForPositionId,
            this.ItemForStatus,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(420, 238);
            // 
            // ItemForPersonalId
            // 
            this.ItemForPersonalId.Control = this.PersonalIdTxt;
            this.ItemForPersonalId.Location = new System.Drawing.Point(0, 0);
            this.ItemForPersonalId.Name = "ItemForPersonalId";
            this.ItemForPersonalId.Size = new System.Drawing.Size(420, 26);
            this.ItemForPersonalId.Text = "პირადი ნომერი";
            this.ItemForPersonalId.TextSize = new System.Drawing.Size(95, 17);
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.Control = this.FirstNameTxt;
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 26);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(420, 26);
            this.ItemForFirstName.Text = "სახელი";
            this.ItemForFirstName.TextSize = new System.Drawing.Size(95, 17);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.LastNameTxt;
            this.ItemForLastName.Location = new System.Drawing.Point(0, 52);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(420, 26);
            this.ItemForLastName.Text = "გვარი";
            this.ItemForLastName.TextSize = new System.Drawing.Size(95, 17);
            // 
            // ItemForLoginName
            // 
            this.ItemForLoginName.Control = this.LoginNameTxt;
            this.ItemForLoginName.Location = new System.Drawing.Point(0, 78);
            this.ItemForLoginName.Name = "ItemForLoginName";
            this.ItemForLoginName.Size = new System.Drawing.Size(420, 26);
            this.ItemForLoginName.Text = "მომხმარებელი";
            this.ItemForLoginName.TextSize = new System.Drawing.Size(95, 17);
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTxt;
            this.ItemForPassword.Location = new System.Drawing.Point(0, 104);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(420, 26);
            this.ItemForPassword.Text = "პაროლი";
            this.ItemForPassword.TextSize = new System.Drawing.Size(95, 17);
            // 
            // ItemForPositionId
            // 
            this.ItemForPositionId.Control = this.PositionCmb;
            this.ItemForPositionId.Location = new System.Drawing.Point(0, 130);
            this.ItemForPositionId.Name = "ItemForPositionId";
            this.ItemForPositionId.Size = new System.Drawing.Size(420, 26);
            this.ItemForPositionId.StartNewLine = true;
            this.ItemForPositionId.Text = "პოზიცია";
            this.ItemForPositionId.TextSize = new System.Drawing.Size(95, 17);
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusCheckEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 156);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(420, 28);
            this.ItemForStatus.Text = "Status";
            this.ItemForStatus.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForStatus.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.RoleCheckedCmb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(420, 54);
            this.layoutControlItem1.Text = "როლი";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 17);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.saveBtn,
            this.closeBtn});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.closeBtn, true)});
            this.bar3.Offset = 333;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.Text = "Status bar";
            // 
            // saveBtn
            // 
            this.saveBtn.Caption = "შენახვა";
            this.saveBtn.Id = 0;
            this.saveBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.ImageOptions.Image")));
            this.saveBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.ImageOptions.LargeImage")));
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // closeBtn
            // 
            this.closeBtn.Caption = "დახურვა";
            this.closeBtn.Id = 1;
            this.closeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.ImageOptions.Image")));
            this.closeBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.ImageOptions.LargeImage")));
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(440, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 258);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(440, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 258);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(440, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 258);
            // 
            // AddOrUpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrUpdateUserForm";
            this.Load += new System.EventHandler(this.AddOrUpdateUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleCheckedCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalIdTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setUserDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPersonalId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLoginName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPositionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource setUserDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit PersonalIdTxt;
        private DevExpress.XtraEditors.TextEdit FirstNameTxt;
        private DevExpress.XtraEditors.TextEdit LastNameTxt;
        private DevExpress.XtraEditors.TextEdit LoginNameTxt;
        private DevExpress.XtraEditors.TextEdit PasswordTxt;
        private DevExpress.XtraEditors.CheckEdit StatusCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPersonalId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLoginName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPositionId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraEditors.CheckedComboBoxEdit RoleCheckedCmb;
        private DevExpress.XtraEditors.ComboBoxEdit PositionCmb;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem closeBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
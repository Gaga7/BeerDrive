
namespace BeerDrive.UI.Forms
{
    partial class AddOrUpdateSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateSupplierForm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NameTxt = new DevExpress.XtraEditors.TextEdit();
            this.setSupplierDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContactFirstNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.ContactLastNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.MobileIndexIdCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MobileTxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobileIndexId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobile = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.NameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSupplierDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactFirstNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactLastNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileIndexIdCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobileIndexId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.NameTxt);
            this.dataLayoutControl1.Controls.Add(this.ContactFirstNameTxt);
            this.dataLayoutControl1.Controls.Add(this.ContactLastNameTxt);
            this.dataLayoutControl1.Controls.Add(this.MobileIndexIdCmb);
            this.dataLayoutControl1.Controls.Add(this.MobileTxt);
            this.dataLayoutControl1.DataSource = this.setSupplierDtoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(395, 159);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 17);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "კონტაქტი";
            // 
            // NameTxt
            // 
            this.NameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setSupplierDtoBindingSource, "Name", true));
            this.NameTxt.Location = new System.Drawing.Point(90, 12);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(293, 22);
            this.NameTxt.StyleController = this.dataLayoutControl1;
            this.NameTxt.TabIndex = 4;
            // 
            // setSupplierDtoBindingSource
            // 
            this.setSupplierDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.SetSupplierDto);
            // 
            // ContactFirstNameTxt
            // 
            this.ContactFirstNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setSupplierDtoBindingSource, "FirstName", true));
            this.ContactFirstNameTxt.Location = new System.Drawing.Point(90, 59);
            this.ContactFirstNameTxt.Name = "ContactFirstNameTxt";
            this.ContactFirstNameTxt.Size = new System.Drawing.Size(293, 22);
            this.ContactFirstNameTxt.StyleController = this.dataLayoutControl1;
            this.ContactFirstNameTxt.TabIndex = 5;
            // 
            // ContactLastNameTxt
            // 
            this.ContactLastNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setSupplierDtoBindingSource, "LastName", true));
            this.ContactLastNameTxt.Location = new System.Drawing.Point(90, 85);
            this.ContactLastNameTxt.Name = "ContactLastNameTxt";
            this.ContactLastNameTxt.Size = new System.Drawing.Size(293, 22);
            this.ContactLastNameTxt.StyleController = this.dataLayoutControl1;
            this.ContactLastNameTxt.TabIndex = 6;
            // 
            // MobileIndexIdCmb
            // 
            this.MobileIndexIdCmb.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setSupplierDtoBindingSource, "MobileIndexId", true));
            this.MobileIndexIdCmb.Location = new System.Drawing.Point(90, 111);
            this.MobileIndexIdCmb.Name = "MobileIndexIdCmb";
            this.MobileIndexIdCmb.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.MobileIndexIdCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MobileIndexIdCmb.Size = new System.Drawing.Size(105, 22);
            this.MobileIndexIdCmb.StyleController = this.dataLayoutControl1;
            this.MobileIndexIdCmb.TabIndex = 7;
            // 
            // MobileTxt
            // 
            this.MobileTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setSupplierDtoBindingSource, "Mobile", true));
            this.MobileTxt.Location = new System.Drawing.Point(199, 111);
            this.MobileTxt.Name = "MobileTxt";
            this.MobileTxt.Properties.Mask.EditMask = "00-00-00";
            this.MobileTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.MobileTxt.Properties.Mask.SaveLiteral = false;
            this.MobileTxt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MobileTxt.Size = new System.Drawing.Size(184, 22);
            this.MobileTxt.StyleController = this.dataLayoutControl1;
            this.MobileTxt.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(395, 159);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForFirstName,
            this.ItemForLastName,
            this.ItemForMobileIndexId,
            this.layoutControlItem1,
            this.ItemForMobile});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(375, 139);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTxt;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(375, 26);
            this.ItemForName.Text = "დასახელება";
            this.ItemForName.TextSize = new System.Drawing.Size(75, 17);
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.Control = this.ContactFirstNameTxt;
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 47);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(375, 26);
            this.ItemForFirstName.Text = "სახელი";
            this.ItemForFirstName.TextSize = new System.Drawing.Size(75, 17);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.ContactLastNameTxt;
            this.ItemForLastName.Location = new System.Drawing.Point(0, 73);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(375, 26);
            this.ItemForLastName.Text = "გვარი";
            this.ItemForLastName.TextSize = new System.Drawing.Size(75, 17);
            // 
            // ItemForMobileIndexId
            // 
            this.ItemForMobileIndexId.Control = this.MobileIndexIdCmb;
            this.ItemForMobileIndexId.CustomizationFormText = "მობილური";
            this.ItemForMobileIndexId.Location = new System.Drawing.Point(0, 99);
            this.ItemForMobileIndexId.Name = "ItemForMobileIndexId";
            this.ItemForMobileIndexId.Size = new System.Drawing.Size(187, 40);
            this.ItemForMobileIndexId.Text = "მობილური";
            this.ItemForMobileIndexId.TextSize = new System.Drawing.Size(75, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(375, 21);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForMobile
            // 
            this.ItemForMobile.Control = this.MobileTxt;
            this.ItemForMobile.Location = new System.Drawing.Point(187, 99);
            this.ItemForMobile.Name = "ItemForMobile";
            this.ItemForMobile.Size = new System.Drawing.Size(188, 40);
            this.ItemForMobile.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForMobile.TextVisible = false;
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
            this.bar3.Offset = 285;
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
            this.barDockControlTop.Size = new System.Drawing.Size(395, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 159);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(395, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 159);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(395, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 159);
            // 
            // AddOrUpdateSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 191);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrUpdateSupplierForm";
            this.Load += new System.EventHandler(this.AddOrUpdateSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSupplierDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactFirstNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactLastNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileIndexIdCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobileIndexId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit NameTxt;
        private System.Windows.Forms.BindingSource setSupplierDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit ContactFirstNameTxt;
        private DevExpress.XtraEditors.TextEdit ContactLastNameTxt;
        private DevExpress.XtraEditors.ComboBoxEdit MobileIndexIdCmb;
        private DevExpress.XtraEditors.TextEdit MobileTxt;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobileIndexId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobile;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem closeBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
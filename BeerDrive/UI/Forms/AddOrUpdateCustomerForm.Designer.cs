
namespace BeerDrive.UI.Forms
{
    partial class AddOrUpdateCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateCustomerForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.closeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.FirstNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.setCustomerDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LastNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.MobileTxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobile = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCustomerDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).BeginInit();
            this.SuspendLayout();
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
            this.bar3.Offset = 165;
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
            this.barDockControlTop.Size = new System.Drawing.Size(276, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 109);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(276, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 109);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(276, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 109);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.FirstNameTxt);
            this.dataLayoutControl1.Controls.Add(this.LastNameTxt);
            this.dataLayoutControl1.Controls.Add(this.MobileTxt);
            this.dataLayoutControl1.DataSource = this.setCustomerDtoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(276, 109);
            this.dataLayoutControl1.TabIndex = 5;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setCustomerDtoBindingSource, "FirstName", true));
            this.FirstNameTxt.Location = new System.Drawing.Point(84, 12);
            this.FirstNameTxt.MenuManager = this.barManager1;
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(180, 22);
            this.FirstNameTxt.StyleController = this.dataLayoutControl1;
            this.FirstNameTxt.TabIndex = 4;
            // 
            // setCustomerDtoBindingSource
            // 
            this.setCustomerDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.SetCustomerDto);
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setCustomerDtoBindingSource, "LastName", true));
            this.LastNameTxt.Location = new System.Drawing.Point(84, 38);
            this.LastNameTxt.MenuManager = this.barManager1;
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(180, 22);
            this.LastNameTxt.StyleController = this.dataLayoutControl1;
            this.LastNameTxt.TabIndex = 5;
            // 
            // MobileTxt
            // 
            this.MobileTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setCustomerDtoBindingSource, "Mobile", true));
            this.MobileTxt.Location = new System.Drawing.Point(84, 64);
            this.MobileTxt.MenuManager = this.barManager1;
            this.MobileTxt.Name = "MobileTxt";
            this.MobileTxt.Properties.Mask.EditMask = "000-00-00-00";
            this.MobileTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.MobileTxt.Size = new System.Drawing.Size(180, 22);
            this.MobileTxt.StyleController = this.dataLayoutControl1;
            this.MobileTxt.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(276, 109);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFirstName,
            this.ItemForLastName,
            this.ItemForMobile});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(256, 89);
            // 
            // ItemForFirstName
            // 
            this.ItemForFirstName.Control = this.FirstNameTxt;
            this.ItemForFirstName.Location = new System.Drawing.Point(0, 0);
            this.ItemForFirstName.Name = "ItemForFirstName";
            this.ItemForFirstName.Size = new System.Drawing.Size(256, 26);
            this.ItemForFirstName.Text = "სახელი";
            this.ItemForFirstName.TextSize = new System.Drawing.Size(69, 17);
            // 
            // ItemForLastName
            // 
            this.ItemForLastName.Control = this.LastNameTxt;
            this.ItemForLastName.Location = new System.Drawing.Point(0, 26);
            this.ItemForLastName.Name = "ItemForLastName";
            this.ItemForLastName.Size = new System.Drawing.Size(256, 26);
            this.ItemForLastName.Text = "გვარი";
            this.ItemForLastName.TextSize = new System.Drawing.Size(69, 17);
            // 
            // ItemForMobile
            // 
            this.ItemForMobile.Control = this.MobileTxt;
            this.ItemForMobile.Location = new System.Drawing.Point(0, 52);
            this.ItemForMobile.Name = "ItemForMobile";
            this.ItemForMobile.Size = new System.Drawing.Size(256, 37);
            this.ItemForMobile.Text = "მობილური";
            this.ItemForMobile.TextSize = new System.Drawing.Size(69, 17);
            // 
            // AddOrUpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 141);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrUpdateCustomerForm";
            this.Load += new System.EventHandler(this.AddOrUpdateCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCustomerDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem closeBtn;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit FirstNameTxt;
        private System.Windows.Forms.BindingSource setCustomerDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit LastNameTxt;
        private DevExpress.XtraEditors.TextEdit MobileTxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobile;
    }
}
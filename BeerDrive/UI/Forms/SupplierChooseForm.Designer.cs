
namespace BeerDrive.UI.Forms
{
    partial class SupplierChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierChooseForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SupplierCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSupplierId = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.saveSupplierBtn = new DevExpress.XtraBars.BarButtonItem();
            this.closeSupplierBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplierId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SupplierCmb);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(362, 62);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SupplierCmb
            // 
            this.SupplierCmb.Location = new System.Drawing.Point(95, 12);
            this.SupplierCmb.Name = "SupplierCmb";
            this.SupplierCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupplierCmb.Size = new System.Drawing.Size(255, 22);
            this.SupplierCmb.StyleController = this.layoutControl1;
            this.SupplierCmb.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSupplierId});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(362, 62);
            this.Root.TextVisible = false;
            // 
            // ItemForSupplierId
            // 
            this.ItemForSupplierId.Control = this.SupplierCmb;
            this.ItemForSupplierId.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ItemForSupplierId.CustomizationFormText = "ორგანიზაცია";
            this.ItemForSupplierId.Location = new System.Drawing.Point(0, 0);
            this.ItemForSupplierId.Name = "ItemForSupplierId";
            this.ItemForSupplierId.Size = new System.Drawing.Size(342, 42);
            this.ItemForSupplierId.Text = "ორგანიზაცია";
            this.ItemForSupplierId.TextSize = new System.Drawing.Size(80, 17);
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
            this.saveSupplierBtn,
            this.closeSupplierBtn});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.saveSupplierBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.closeSupplierBtn, true)});
            this.bar3.Offset = 335;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.Text = "Status bar";
            // 
            // saveSupplierBtn
            // 
            this.saveSupplierBtn.Caption = "შენახვა";
            this.saveSupplierBtn.Id = 0;
            this.saveSupplierBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveSupplierBtn.ImageOptions.Image")));
            this.saveSupplierBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveSupplierBtn.ImageOptions.LargeImage")));
            this.saveSupplierBtn.Name = "saveSupplierBtn";
            this.saveSupplierBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveSupplierBtn_ItemClick);
            // 
            // closeSupplierBtn
            // 
            this.closeSupplierBtn.Caption = "დახურვა";
            this.closeSupplierBtn.Id = 1;
            this.closeSupplierBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeSupplierBtn.ImageOptions.Image")));
            this.closeSupplierBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("closeSupplierBtn.ImageOptions.LargeImage")));
            this.closeSupplierBtn.Name = "closeSupplierBtn";
            this.closeSupplierBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseSupplierBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(362, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 62);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(362, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 62);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(362, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 62);
            // 
            // SupplierChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 94);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SupplierChooseForm";
            this.Load += new System.EventHandler(this.SupplierChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplierId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ComboBoxEdit SupplierCmb;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupplierId;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem saveSupplierBtn;
        private DevExpress.XtraBars.BarButtonItem closeSupplierBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
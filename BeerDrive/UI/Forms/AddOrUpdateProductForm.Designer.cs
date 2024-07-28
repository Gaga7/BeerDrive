
namespace BeerDrive.UI.Forms
{
    partial class AddOrUpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateProductForm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameTxt = new DevExpress.XtraEditors.TextEdit();
            this.setProductDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BarcodeTxt = new DevExpress.XtraEditors.TextEdit();
            this.CategoryCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SupplierCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MeasureUnitTypeCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.UnitInStockSpn = new DevExpress.XtraEditors.SpinEdit();
            this.UnitPriceSpn = new DevExpress.XtraEditors.SpinEdit();
            this.DisableCheckInStockCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.SetPriceDuringSellCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBarcode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSupplierId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitInStock = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMeasureUnitTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDisableCheckInStock = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSetPriceDuringSell = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setProductDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureUnitTypeCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInStockSpn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceSpn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisableCheckInStockCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetPriceDuringSellCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplierId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMeasureUnitTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisableCheckInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSetPriceDuringSell)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameTxt);
            this.dataLayoutControl1.Controls.Add(this.BarcodeTxt);
            this.dataLayoutControl1.Controls.Add(this.CategoryCmb);
            this.dataLayoutControl1.Controls.Add(this.SupplierCmb);
            this.dataLayoutControl1.Controls.Add(this.MeasureUnitTypeCmb);
            this.dataLayoutControl1.Controls.Add(this.UnitInStockSpn);
            this.dataLayoutControl1.Controls.Add(this.UnitPriceSpn);
            this.dataLayoutControl1.Controls.Add(this.DisableCheckInStockCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.SetPriceDuringSellCheckEdit);
            this.dataLayoutControl1.DataSource = this.setProductDtoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(448, 268);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTxt
            // 
            this.NameTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setProductDtoBindingSource, "Name", true));
            this.NameTxt.Location = new System.Drawing.Point(147, 12);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(289, 22);
            this.NameTxt.StyleController = this.dataLayoutControl1;
            this.NameTxt.TabIndex = 4;
            // 
            // setProductDtoBindingSource
            // 
            this.setProductDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.SetProductDto);
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setProductDtoBindingSource, "Barcode", true));
            this.BarcodeTxt.Location = new System.Drawing.Point(147, 38);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(289, 22);
            this.BarcodeTxt.StyleController = this.dataLayoutControl1;
            this.BarcodeTxt.TabIndex = 5;
            // 
            // CategoryCmb
            // 
            this.CategoryCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.setProductDtoBindingSource, "CategoryId", true));
            this.CategoryCmb.Location = new System.Drawing.Point(147, 64);
            this.CategoryCmb.Name = "CategoryCmb";
            this.CategoryCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryCmb.Size = new System.Drawing.Size(289, 22);
            this.CategoryCmb.StyleController = this.dataLayoutControl1;
            this.CategoryCmb.TabIndex = 6;
            // 
            // SupplierCmb
            // 
            this.SupplierCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.setProductDtoBindingSource, "SupplierId", true));
            this.SupplierCmb.Location = new System.Drawing.Point(147, 90);
            this.SupplierCmb.Name = "SupplierCmb";
            this.SupplierCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SupplierCmb.Size = new System.Drawing.Size(289, 22);
            this.SupplierCmb.StyleController = this.dataLayoutControl1;
            this.SupplierCmb.TabIndex = 7;
            // 
            // MeasureUnitTypeCmb
            // 
            this.MeasureUnitTypeCmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.setProductDtoBindingSource, "MeasureUnitTypeId", true));
            this.MeasureUnitTypeCmb.Location = new System.Drawing.Point(147, 144);
            this.MeasureUnitTypeCmb.Name = "MeasureUnitTypeCmb";
            this.MeasureUnitTypeCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MeasureUnitTypeCmb.Size = new System.Drawing.Size(289, 22);
            this.MeasureUnitTypeCmb.StyleController = this.dataLayoutControl1;
            this.MeasureUnitTypeCmb.TabIndex = 10;
            // 
            // UnitInStockSpn
            // 
            this.UnitInStockSpn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setProductDtoBindingSource, "UnitInStock", true));
            this.UnitInStockSpn.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UnitInStockSpn.Location = new System.Drawing.Point(147, 116);
            this.UnitInStockSpn.Name = "UnitInStockSpn";
            this.UnitInStockSpn.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitInStockSpn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.UnitInStockSpn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UnitInStockSpn.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.UnitInStockSpn.Properties.Mask.EditMask = "G";
            this.UnitInStockSpn.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitInStockSpn.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.UnitInStockSpn.Size = new System.Drawing.Size(289, 24);
            this.UnitInStockSpn.StyleController = this.dataLayoutControl1;
            this.UnitInStockSpn.TabIndex = 8;
            // 
            // UnitPriceSpn
            // 
            this.UnitPriceSpn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setProductDtoBindingSource, "UnitPrice", true));
            this.UnitPriceSpn.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UnitPriceSpn.Location = new System.Drawing.Point(147, 170);
            this.UnitPriceSpn.Name = "UnitPriceSpn";
            this.UnitPriceSpn.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitPriceSpn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.UnitPriceSpn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UnitPriceSpn.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.UnitPriceSpn.Properties.Mask.EditMask = "G";
            this.UnitPriceSpn.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitPriceSpn.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.UnitPriceSpn.Size = new System.Drawing.Size(289, 24);
            this.UnitPriceSpn.StyleController = this.dataLayoutControl1;
            this.UnitPriceSpn.TabIndex = 9;
            // 
            // DisableCheckInStockCheckEdit
            // 
            this.DisableCheckInStockCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setProductDtoBindingSource, "DisableCheckInStock", true));
            this.DisableCheckInStockCheckEdit.Location = new System.Drawing.Point(12, 198);
            this.DisableCheckInStockCheckEdit.MenuManager = this.barManager1;
            this.DisableCheckInStockCheckEdit.Name = "DisableCheckInStockCheckEdit";
            this.DisableCheckInStockCheckEdit.Properties.Caption = "არ შემოწმდეს რაოდენობა";
            this.DisableCheckInStockCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.DisableCheckInStockCheckEdit.Size = new System.Drawing.Size(203, 24);
            this.DisableCheckInStockCheckEdit.StyleController = this.dataLayoutControl1;
            this.DisableCheckInStockCheckEdit.TabIndex = 11;
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
            this.cancelBtn});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBtn, true)});
            this.bar3.Offset = 340;
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
            // cancelBtn
            // 
            this.cancelBtn.Caption = "დახურვა";
            this.cancelBtn.Id = 1;
            this.cancelBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.ImageOptions.Image")));
            this.cancelBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.ImageOptions.LargeImage")));
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CancelBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(448, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 268);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(448, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 268);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(448, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 268);
            // 
            // SetPriceDuringSellCheckEdit
            // 
            this.SetPriceDuringSellCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setProductDtoBindingSource, "SetPriceDuringSell", true));
            this.SetPriceDuringSellCheckEdit.Location = new System.Drawing.Point(219, 198);
            this.SetPriceDuringSellCheckEdit.MenuManager = this.barManager1;
            this.SetPriceDuringSellCheckEdit.Name = "SetPriceDuringSellCheckEdit";
            this.SetPriceDuringSellCheckEdit.Properties.Caption = "ფასი გაყიდვის დროს";
            this.SetPriceDuringSellCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.SetPriceDuringSellCheckEdit.Size = new System.Drawing.Size(217, 24);
            this.SetPriceDuringSellCheckEdit.StyleController = this.dataLayoutControl1;
            this.SetPriceDuringSellCheckEdit.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(448, 268);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForBarcode,
            this.ItemForCategoryId,
            this.ItemForSupplierId,
            this.ItemForUnitInStock,
            this.ItemForMeasureUnitTypeId,
            this.ItemForUnitPrice,
            this.ItemForDisableCheckInStock,
            this.ItemForSetPriceDuringSell});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(428, 248);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTxt;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(428, 26);
            this.ItemForName.Text = "დასახელება";
            this.ItemForName.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForBarcode
            // 
            this.ItemForBarcode.Control = this.BarcodeTxt;
            this.ItemForBarcode.Location = new System.Drawing.Point(0, 26);
            this.ItemForBarcode.Name = "ItemForBarcode";
            this.ItemForBarcode.Size = new System.Drawing.Size(428, 26);
            this.ItemForBarcode.Text = "ბარკოდი";
            this.ItemForBarcode.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForCategoryId
            // 
            this.ItemForCategoryId.Control = this.CategoryCmb;
            this.ItemForCategoryId.Location = new System.Drawing.Point(0, 52);
            this.ItemForCategoryId.Name = "ItemForCategoryId";
            this.ItemForCategoryId.Size = new System.Drawing.Size(428, 26);
            this.ItemForCategoryId.Text = "კატეგორია";
            this.ItemForCategoryId.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForSupplierId
            // 
            this.ItemForSupplierId.Control = this.SupplierCmb;
            this.ItemForSupplierId.Location = new System.Drawing.Point(0, 78);
            this.ItemForSupplierId.Name = "ItemForSupplierId";
            this.ItemForSupplierId.Size = new System.Drawing.Size(428, 26);
            this.ItemForSupplierId.Text = "ორგანიზაცია";
            this.ItemForSupplierId.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForUnitInStock
            // 
            this.ItemForUnitInStock.Control = this.UnitInStockSpn;
            this.ItemForUnitInStock.Location = new System.Drawing.Point(0, 104);
            this.ItemForUnitInStock.Name = "ItemForUnitInStock";
            this.ItemForUnitInStock.Size = new System.Drawing.Size(428, 28);
            this.ItemForUnitInStock.Text = "რაოდენობა საწყობში";
            this.ItemForUnitInStock.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForMeasureUnitTypeId
            // 
            this.ItemForMeasureUnitTypeId.Control = this.MeasureUnitTypeCmb;
            this.ItemForMeasureUnitTypeId.Location = new System.Drawing.Point(0, 132);
            this.ItemForMeasureUnitTypeId.Name = "ItemForMeasureUnitTypeId";
            this.ItemForMeasureUnitTypeId.Size = new System.Drawing.Size(428, 26);
            this.ItemForMeasureUnitTypeId.Text = "ზომის ერთეული";
            this.ItemForMeasureUnitTypeId.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForUnitPrice
            // 
            this.ItemForUnitPrice.Control = this.UnitPriceSpn;
            this.ItemForUnitPrice.Location = new System.Drawing.Point(0, 158);
            this.ItemForUnitPrice.Name = "ItemForUnitPrice";
            this.ItemForUnitPrice.Size = new System.Drawing.Size(428, 28);
            this.ItemForUnitPrice.Text = "ერთეულის ფასი";
            this.ItemForUnitPrice.TextSize = new System.Drawing.Size(132, 17);
            // 
            // ItemForDisableCheckInStock
            // 
            this.ItemForDisableCheckInStock.Control = this.DisableCheckInStockCheckEdit;
            this.ItemForDisableCheckInStock.Location = new System.Drawing.Point(0, 186);
            this.ItemForDisableCheckInStock.Name = "ItemForDisableCheckInStock";
            this.ItemForDisableCheckInStock.Size = new System.Drawing.Size(207, 62);
            this.ItemForDisableCheckInStock.Text = "Disable Check In Stock";
            this.ItemForDisableCheckInStock.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDisableCheckInStock.TextVisible = false;
            // 
            // ItemForSetPriceDuringSell
            // 
            this.ItemForSetPriceDuringSell.Control = this.SetPriceDuringSellCheckEdit;
            this.ItemForSetPriceDuringSell.Location = new System.Drawing.Point(207, 186);
            this.ItemForSetPriceDuringSell.Name = "ItemForSetPriceDuringSell";
            this.ItemForSetPriceDuringSell.Size = new System.Drawing.Size(221, 62);
            this.ItemForSetPriceDuringSell.Text = "Set Price During Sell";
            this.ItemForSetPriceDuringSell.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForSetPriceDuringSell.TextVisible = false;
            // 
            // AddOrUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 300);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrUpdateProductForm";
            this.Load += new System.EventHandler(this.AddOrUpdateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setProductDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureUnitTypeCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInStockSpn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceSpn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisableCheckInStockCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetPriceDuringSellCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSupplierId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMeasureUnitTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDisableCheckInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSetPriceDuringSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit NameTxt;
        private System.Windows.Forms.BindingSource setProductDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit BarcodeTxt;
        private DevExpress.XtraEditors.ComboBoxEdit CategoryCmb;
        private DevExpress.XtraEditors.ComboBoxEdit SupplierCmb;
        private DevExpress.XtraEditors.ComboBoxEdit MeasureUnitTypeCmb;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBarcode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSupplierId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitInStock;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMeasureUnitTypeId;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem cancelBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SpinEdit UnitInStockSpn;
        private DevExpress.XtraEditors.SpinEdit UnitPriceSpn;
        private DevExpress.XtraEditors.CheckEdit DisableCheckInStockCheckEdit;
        private DevExpress.XtraEditors.CheckEdit SetPriceDuringSellCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDisableCheckInStock;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSetPriceDuringSell;
    }
}
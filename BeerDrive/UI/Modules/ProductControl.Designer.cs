
namespace BeerDrive.UI.Modules
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.productsGridview = new DevExpress.XtraGrid.GridControl();
            this.productDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeasureUnitType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addProductBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editProductBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteProductBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.colDisableCheckInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSetPriceDuringSell = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.productsGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(945, 546);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // productsGridview
            // 
            this.productsGridview.DataSource = this.productDtoBindingSource;
            this.productsGridview.Location = new System.Drawing.Point(12, 12);
            this.productsGridview.MainView = this.gridView1;
            this.productsGridview.Name = "productsGridview";
            this.productsGridview.Size = new System.Drawing.Size(921, 522);
            this.productsGridview.TabIndex = 4;
            this.productsGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.productsGridview.Load += new System.EventHandler(this.ProductsGridview_Load);
            // 
            // productDtoBindingSource
            // 
            this.productDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetProductDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colBarcode,
            this.colCategory,
            this.colSupplier,
            this.colUnitInStock,
            this.colUnitPrice,
            this.colMeasureUnitType,
            this.colDisableCheckInStock,
            this.colSetPriceDuringSell,
            this.colDateCreated});
            this.gridView1.GridControl = this.productsGridview;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colName
            // 
            this.colName.Caption = "დასახელება";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colBarcode
            // 
            this.colBarcode.Caption = "ბარკოდი";
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.MinWidth = 25;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 1;
            this.colBarcode.Width = 94;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "კატეგორია";
            this.colCategory.FieldName = "Category";
            this.colCategory.MinWidth = 25;
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 2;
            this.colCategory.Width = 94;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "ორგანიზაცია";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.MinWidth = 25;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 3;
            this.colSupplier.Width = 94;
            // 
            // colUnitInStock
            // 
            this.colUnitInStock.AppearanceCell.Options.UseTextOptions = true;
            this.colUnitInStock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnitInStock.Caption = "რაოდენობა";
            this.colUnitInStock.FieldName = "UnitInStock";
            this.colUnitInStock.MinWidth = 25;
            this.colUnitInStock.Name = "colUnitInStock";
            this.colUnitInStock.Visible = true;
            this.colUnitInStock.VisibleIndex = 4;
            this.colUnitInStock.Width = 94;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnitPrice.Caption = "ერთეულის ფასი";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.MinWidth = 25;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            this.colUnitPrice.Width = 94;
            // 
            // colMeasureUnitType
            // 
            this.colMeasureUnitType.Caption = "ზომის ერთეული";
            this.colMeasureUnitType.FieldName = "MeasureUnitType";
            this.colMeasureUnitType.MinWidth = 25;
            this.colMeasureUnitType.Name = "colMeasureUnitType";
            this.colMeasureUnitType.Visible = true;
            this.colMeasureUnitType.VisibleIndex = 5;
            this.colMeasureUnitType.Width = 94;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "შექმნის თარიღი";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.MinWidth = 25;
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 9;
            this.colDateCreated.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(945, 546);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.productsGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(925, 526);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addProductBtn,
            this.editProductBtn,
            this.deleteProductBtn,
            this.refreshBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addProductBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.editProductBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteProductBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Caption = "დამატება";
            this.addProductBtn.Id = 0;
            this.addProductBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addProductBtn.ImageOptions.Image")));
            this.addProductBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addProductBtn.ImageOptions.LargeImage")));
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddProductBtn_ItemClick);
            // 
            // editProductBtn
            // 
            this.editProductBtn.Caption = "რედაქტირება";
            this.editProductBtn.Id = 1;
            this.editProductBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editProductBtn.ImageOptions.Image")));
            this.editProductBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editProductBtn.ImageOptions.LargeImage")));
            this.editProductBtn.Name = "editProductBtn";
            this.editProductBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditProductBtn_ItemClick);
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Caption = "წაშლა";
            this.deleteProductBtn.Id = 2;
            this.deleteProductBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductBtn.ImageOptions.Image")));
            this.deleteProductBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteProductBtn.ImageOptions.LargeImage")));
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteProductBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "განახლება";
            this.refreshBtn.Id = 3;
            this.refreshBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.ImageOptions.Image")));
            this.refreshBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.ImageOptions.LargeImage")));
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(945, 30);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 576);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(945, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 546);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(945, 30);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 546);
            // 
            // colDisableCheckInStock
            // 
            this.colDisableCheckInStock.Caption = "არ შემოწმდეს საწყობში";
            this.colDisableCheckInStock.FieldName = "DisableCheckInStock";
            this.colDisableCheckInStock.MinWidth = 25;
            this.colDisableCheckInStock.Name = "colDisableCheckInStock";
            this.colDisableCheckInStock.Visible = true;
            this.colDisableCheckInStock.VisibleIndex = 7;
            this.colDisableCheckInStock.Width = 94;
            // 
            // colSetPriceDuringSell
            // 
            this.colSetPriceDuringSell.Caption = "ფასი გაყიდვის დროს";
            this.colSetPriceDuringSell.FieldName = "SetPriceDuringSell";
            this.colSetPriceDuringSell.MinWidth = 25;
            this.colSetPriceDuringSell.Name = "colSetPriceDuringSell";
            this.colSetPriceDuringSell.Visible = true;
            this.colSetPriceDuringSell.VisibleIndex = 8;
            this.colSetPriceDuringSell.Width = 94;
            // 
            // ProductControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(945, 576);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl productsGridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource productDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMeasureUnitType;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addProductBtn;
        private DevExpress.XtraBars.BarButtonItem editProductBtn;
        private DevExpress.XtraBars.BarButtonItem deleteProductBtn;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colDisableCheckInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colSetPriceDuringSell;
    }
}

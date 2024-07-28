
namespace BeerDrive.UI.Modules
{
    partial class OrderDetailControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.orderDetailsGridview = new DevExpress.XtraGrid.GridControl();
            this.getOrderDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierContactMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatecreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.orderDetailsGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(875, 469);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // orderDetailsGridview
            // 
            this.orderDetailsGridview.DataSource = this.getOrderDetailDtoBindingSource;
            this.orderDetailsGridview.Location = new System.Drawing.Point(12, 12);
            this.orderDetailsGridview.MainView = this.gridView1;
            this.orderDetailsGridview.Name = "orderDetailsGridview";
            this.orderDetailsGridview.Size = new System.Drawing.Size(851, 445);
            this.orderDetailsGridview.TabIndex = 4;
            this.orderDetailsGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.orderDetailsGridview.Load += new System.EventHandler(this.OrderDetailsGridview_Load);
            // 
            // getOrderDetailDtoBindingSource
            // 
            this.getOrderDetailDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetOrderDetailDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOrderDate,
            this.colProductName,
            this.colCategoryName,
            this.colQuantity,
            this.colUnitPrice,
            this.colTotalPrice,
            this.colSupplier,
            this.colSupplierContactName,
            this.colSupplierContactMobile,
            this.colUserFullName,
            this.colDatecreated});
            this.gridView1.DetailHeight = 372;
            this.gridView1.GridControl = this.orderDetailsGridview;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 29;
            this.colId.Name = "colId";
            this.colId.Width = 107;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "შეკვეთის თარიღი";
            this.colOrderDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 29;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 0;
            this.colOrderDate.Width = 107;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "პროდუქტი";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.MinWidth = 29;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 107;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "კატეგორია";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.MinWidth = 29;
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 2;
            this.colCategoryName.Width = 107;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "რაოდენობა";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 29;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "ჯამი={0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 107;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "ერთეულის ფასი";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.MinWidth = 29;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 107;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "ჯამი";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "ჯამი={0:0.####}")});
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 5;
            this.colTotalPrice.Width = 94;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "კომპანია";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.MinWidth = 29;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 6;
            this.colSupplier.Width = 107;
            // 
            // colSupplierContactName
            // 
            this.colSupplierContactName.Caption = "კონტაქტი (კომპანია)";
            this.colSupplierContactName.FieldName = "SupplierContactName";
            this.colSupplierContactName.MinWidth = 29;
            this.colSupplierContactName.Name = "colSupplierContactName";
            this.colSupplierContactName.Visible = true;
            this.colSupplierContactName.VisibleIndex = 7;
            this.colSupplierContactName.Width = 107;
            // 
            // colSupplierContactMobile
            // 
            this.colSupplierContactMobile.Caption = "მობილური";
            this.colSupplierContactMobile.FieldName = "SupplierContactMobile";
            this.colSupplierContactMobile.MinWidth = 29;
            this.colSupplierContactMobile.Name = "colSupplierContactMobile";
            this.colSupplierContactMobile.Visible = true;
            this.colSupplierContactMobile.VisibleIndex = 8;
            this.colSupplierContactMobile.Width = 107;
            // 
            // colUserFullName
            // 
            this.colUserFullName.Caption = "მომხმარებელი";
            this.colUserFullName.FieldName = "UserFullName";
            this.colUserFullName.MinWidth = 29;
            this.colUserFullName.Name = "colUserFullName";
            this.colUserFullName.Visible = true;
            this.colUserFullName.VisibleIndex = 9;
            this.colUserFullName.Width = 107;
            // 
            // colDatecreated
            // 
            this.colDatecreated.Caption = "შექმნის თარიღი";
            this.colDatecreated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colDatecreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDatecreated.FieldName = "DateCreated";
            this.colDatecreated.MinWidth = 29;
            this.colDatecreated.Name = "colDatecreated";
            this.colDatecreated.Visible = true;
            this.colDatecreated.VisibleIndex = 10;
            this.colDatecreated.Width = 107;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(875, 469);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.orderDetailsGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(855, 449);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.refreshBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(875, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 499);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(875, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 469);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(875, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 469);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "განახლება";
            this.refreshBtn.Id = 0;
            this.refreshBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.refreshBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // OrderDetailControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "OrderDetailControl";
            this.Size = new System.Drawing.Size(875, 499);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl orderDetailsGridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource getOrderDetailDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierContactMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colUserFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDatecreated;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}

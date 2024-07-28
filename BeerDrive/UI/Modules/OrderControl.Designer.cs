
namespace BeerDrive.UI.Modules
{
    partial class OrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ordersGridview = new DevExpress.XtraGrid.GridControl();
            this.getOrderDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ordersGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(938, 552);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ordersGridview
            // 
            this.ordersGridview.DataSource = this.getOrderDtoBindingSource;
            this.ordersGridview.Location = new System.Drawing.Point(12, 12);
            this.ordersGridview.MainView = this.gridView1;
            this.ordersGridview.Name = "ordersGridview";
            this.ordersGridview.Size = new System.Drawing.Size(914, 528);
            this.ordersGridview.TabIndex = 4;
            this.ordersGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.ordersGridview.Load += new System.EventHandler(this.OrdersGridview_Load);
            // 
            // getOrderDtoBindingSource
            // 
            this.getOrderDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetOrderDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserId,
            this.colUser,
            this.colOrderDate,
            this.colDateCreated,
            this.colOrderNumber,
            this.colTotalQuantity,
            this.colTotalAmount});
            this.gridView1.DetailHeight = 372;
            this.gridView1.GridControl = this.ordersGridview;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.MinWidth = 25;
            this.colUserId.Name = "colUserId";
            this.colUserId.Width = 94;
            // 
            // colUser
            // 
            this.colUser.Caption = "მომხმარებელი";
            this.colUser.FieldName = "User";
            this.colUser.MinWidth = 25;
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 1;
            this.colUser.Width = 94;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "შეკვეთის თარიღი";
            this.colOrderDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 25;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 4;
            this.colOrderDate.Width = 94;
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
            this.colDateCreated.VisibleIndex = 5;
            this.colDateCreated.Width = 94;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.Caption = "შეკვეთის ნომერი";
            this.colOrderNumber.FieldName = "OrderNumber";
            this.colOrderNumber.MinWidth = 25;
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.Visible = true;
            this.colOrderNumber.VisibleIndex = 0;
            this.colOrderNumber.Width = 94;
            // 
            // colTotalQuantity
            // 
            this.colTotalQuantity.Caption = "რაოდენობა";
            this.colTotalQuantity.FieldName = "TotalQuantity";
            this.colTotalQuantity.MinWidth = 25;
            this.colTotalQuantity.Name = "colTotalQuantity";
            this.colTotalQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalQuantity", "ჯამი={0:0.##}")});
            this.colTotalQuantity.Visible = true;
            this.colTotalQuantity.VisibleIndex = 2;
            this.colTotalQuantity.Width = 94;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "თანხა";
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.MinWidth = 25;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "ჯამი={0:0.####}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 3;
            this.colTotalAmount.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(938, 552);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ordersGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(918, 532);
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
            this.addOrderBtn,
            this.editOrderBtn,
            this.deleteOrderBtn,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.addOrderBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.editOrderBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOrderBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Caption = "დამატება";
            this.addOrderBtn.Id = 0;
            this.addOrderBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addOrderBtn.ImageOptions.Image")));
            this.addOrderBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addOrderBtn.ImageOptions.LargeImage")));
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddOrderBtn_ItemClick);
            // 
            // editOrderBtn
            // 
            this.editOrderBtn.Caption = "რედაქტირება";
            this.editOrderBtn.Id = 1;
            this.editOrderBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editOrderBtn.ImageOptions.Image")));
            this.editOrderBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editOrderBtn.ImageOptions.LargeImage")));
            this.editOrderBtn.Name = "editOrderBtn";
            this.editOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditOrderBtn_ItemClick);
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Caption = "წაშლა";
            this.deleteOrderBtn.Id = 2;
            this.deleteOrderBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteOrderBtn.ImageOptions.Image")));
            this.deleteOrderBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteOrderBtn.ImageOptions.LargeImage")));
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteOrderBtn_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(938, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(938, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 552);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(938, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 552);
            // 
            // OrderControl
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
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(938, 582);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDtoBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl ordersGridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource getOrderDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addOrderBtn;
        private DevExpress.XtraBars.BarButtonItem editOrderBtn;
        private DevExpress.XtraBars.BarButtonItem deleteOrderBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderNumber;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
    }
}


namespace BeerDrive.UI.Modules
{
    partial class TransactionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.transactionsGridview = new DevExpress.XtraGrid.GridControl();
            this.getTransactionDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionStatusTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionStatusTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.viewDetailsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTransactionDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.transactionsGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(920, 509);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // transactionsGridview
            // 
            this.transactionsGridview.DataSource = this.getTransactionDtoBindingSource;
            this.transactionsGridview.Location = new System.Drawing.Point(12, 12);
            this.transactionsGridview.MainView = this.gridView1;
            this.transactionsGridview.Name = "transactionsGridview";
            this.transactionsGridview.Size = new System.Drawing.Size(896, 485);
            this.transactionsGridview.TabIndex = 4;
            this.transactionsGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getTransactionDtoBindingSource
            // 
            this.getTransactionDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetTransactionDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPayTypeId,
            this.colPayTypeName,
            this.colTransactionStatusTypeId,
            this.colTransactionStatusTypeName,
            this.colTransactionNumber,
            this.colTotalQuantity,
            this.colTotalAmount,
            this.colCash,
            this.colChange,
            this.colDateCreated,
            this.colUser});
            this.gridView1.GridControl = this.transactionsGridview;
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
            // colPayTypeId
            // 
            this.colPayTypeId.FieldName = "PayTypeId";
            this.colPayTypeId.MinWidth = 25;
            this.colPayTypeId.Name = "colPayTypeId";
            this.colPayTypeId.Width = 94;
            // 
            // colPayTypeName
            // 
            this.colPayTypeName.Caption = "გადახდის მეთოდი";
            this.colPayTypeName.FieldName = "PayTypeName";
            this.colPayTypeName.MinWidth = 25;
            this.colPayTypeName.Name = "colPayTypeName";
            this.colPayTypeName.Visible = true;
            this.colPayTypeName.VisibleIndex = 6;
            this.colPayTypeName.Width = 94;
            // 
            // colTransactionStatusTypeId
            // 
            this.colTransactionStatusTypeId.FieldName = "TransactionStatusTypeId";
            this.colTransactionStatusTypeId.MinWidth = 25;
            this.colTransactionStatusTypeId.Name = "colTransactionStatusTypeId";
            this.colTransactionStatusTypeId.Width = 94;
            // 
            // colTransactionStatusTypeName
            // 
            this.colTransactionStatusTypeName.Caption = "სტატუსი";
            this.colTransactionStatusTypeName.FieldName = "TransactionStatusTypeName";
            this.colTransactionStatusTypeName.MinWidth = 25;
            this.colTransactionStatusTypeName.Name = "colTransactionStatusTypeName";
            this.colTransactionStatusTypeName.Visible = true;
            this.colTransactionStatusTypeName.VisibleIndex = 7;
            this.colTransactionStatusTypeName.Width = 94;
            // 
            // colTransactionNumber
            // 
            this.colTransactionNumber.Caption = "ტრანზაქციის N";
            this.colTransactionNumber.FieldName = "TransactionNumber";
            this.colTransactionNumber.MinWidth = 25;
            this.colTransactionNumber.Name = "colTransactionNumber";
            this.colTransactionNumber.Visible = true;
            this.colTransactionNumber.VisibleIndex = 1;
            this.colTransactionNumber.Width = 94;
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "ჯამი={0:0.##}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 3;
            this.colTotalAmount.Width = 94;
            // 
            // colCash
            // 
            this.colCash.Caption = "თანხა (მიღებული)";
            this.colCash.FieldName = "Cash";
            this.colCash.MinWidth = 25;
            this.colCash.Name = "colCash";
            this.colCash.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cash", "ჯამი={0:0.##}")});
            this.colCash.Visible = true;
            this.colCash.VisibleIndex = 4;
            this.colCash.Width = 94;
            // 
            // colChange
            // 
            this.colChange.Caption = "ხურდა";
            this.colChange.FieldName = "Change";
            this.colChange.MinWidth = 25;
            this.colChange.Name = "colChange";
            this.colChange.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Change", "ჯამი={0:0.##}")});
            this.colChange.Visible = true;
            this.colChange.VisibleIndex = 5;
            this.colChange.Width = 94;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "თარიღი";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.MinWidth = 25;
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 0;
            this.colDateCreated.Width = 94;
            // 
            // colUser
            // 
            this.colUser.Caption = "მომხმარებელი";
            this.colUser.FieldName = "User";
            this.colUser.MinWidth = 25;
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 8;
            this.colUser.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(920, 509);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.transactionsGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(900, 489);
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
            this.viewDetailsBtn,
            this.refreshBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.viewDetailsBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // viewDetailsBtn
            // 
            this.viewDetailsBtn.Caption = "დათვალიერება";
            this.viewDetailsBtn.Id = 0;
            this.viewDetailsBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("viewDetailsBtn.ImageOptions.Image")));
            this.viewDetailsBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("viewDetailsBtn.ImageOptions.LargeImage")));
            this.viewDetailsBtn.Name = "viewDetailsBtn";
            this.viewDetailsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ViewDetailsBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "განახლება";
            this.refreshBtn.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(920, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 539);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(920, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 509);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(920, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 509);
            // 
            // TransactionControl
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
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(920, 539);
            this.Load += new System.EventHandler(this.TransactionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTransactionDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl transactionsGridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionStatusTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionStatusTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private System.Windows.Forms.BindingSource getTransactionDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCash;
        private DevExpress.XtraGrid.Columns.GridColumn colChange;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem viewDetailsBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
    }
}

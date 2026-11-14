
namespace BeerDrive.UI.Modules
{
    partial class ExchangeRatesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeRatesControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.exchangeRatesGridview = new DevExpress.XtraGrid.GridControl();
            this.getExchangeRateDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addExchangeRateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editExchangeRateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteExchangeRateBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRatesGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRateDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.exchangeRatesGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(784, 402);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // exchangeRatesGridview
            // 
            this.exchangeRatesGridview.DataSource = this.getExchangeRateDtoBindingSource;
            this.exchangeRatesGridview.Location = new System.Drawing.Point(12, 12);
            this.exchangeRatesGridview.MainView = this.gridView1;
            this.exchangeRatesGridview.Name = "exchangeRatesGridview";
            this.exchangeRatesGridview.Size = new System.Drawing.Size(760, 378);
            this.exchangeRatesGridview.TabIndex = 4;
            this.exchangeRatesGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.exchangeRatesGridview.Load += new System.EventHandler(this.ExchangeRatesGridview_Load);
            // 
            // getExchangeRateDtoBindingSource
            // 
            this.getExchangeRateDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetExchangeRateDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colExchangeTypeId,
            this.colExchangeType,
            this.colScore,
            this.colAmount,
            this.colDateCreated});
            this.gridView1.GridControl = this.exchangeRatesGridview;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colExchangeTypeId
            // 
            this.colExchangeTypeId.FieldName = "ExchangeTypeId";
            this.colExchangeTypeId.MinWidth = 25;
            this.colExchangeTypeId.Name = "colExchangeTypeId";
            this.colExchangeTypeId.Width = 94;
            // 
            // colExchangeType
            // 
            this.colExchangeType.Caption = "ტიპი";
            this.colExchangeType.FieldName = "ExchangeType";
            this.colExchangeType.MinWidth = 25;
            this.colExchangeType.Name = "colExchangeType";
            this.colExchangeType.Visible = true;
            this.colExchangeType.VisibleIndex = 0;
            this.colExchangeType.Width = 94;
            // 
            // colScore
            // 
            this.colScore.Caption = "ქულა";
            this.colScore.FieldName = "Score";
            this.colScore.MinWidth = 25;
            this.colScore.Name = "colScore";
            this.colScore.Visible = true;
            this.colScore.VisibleIndex = 1;
            this.colScore.Width = 94;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "თანხა";
            this.colAmount.FieldName = "Amount";
            this.colAmount.MinWidth = 25;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 94;
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
            this.colDateCreated.VisibleIndex = 3;
            this.colDateCreated.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(784, 402);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.exchangeRatesGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 382);
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
            this.addExchangeRateBtn,
            this.editExchangeRateBtn,
            this.deleteExchangeRateBtn,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.addExchangeRateBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.editExchangeRateBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteExchangeRateBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addExchangeRateBtn
            // 
            this.addExchangeRateBtn.Caption = "დამატება";
            this.addExchangeRateBtn.Id = 0;
            this.addExchangeRateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addExchangeRateBtn.ImageOptions.Image")));
            this.addExchangeRateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addExchangeRateBtn.ImageOptions.LargeImage")));
            this.addExchangeRateBtn.Name = "addExchangeRateBtn";
            this.addExchangeRateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddExchangeRateBtn_ItemClick);
            // 
            // editExchangeRateBtn
            // 
            this.editExchangeRateBtn.Caption = "რედაქტირება";
            this.editExchangeRateBtn.Id = 1;
            this.editExchangeRateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editExchangeRateBtn.ImageOptions.Image")));
            this.editExchangeRateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editExchangeRateBtn.ImageOptions.LargeImage")));
            this.editExchangeRateBtn.Name = "editExchangeRateBtn";
            this.editExchangeRateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditExchangeRateBtn_ItemClick);
            // 
            // deleteExchangeRateBtn
            // 
            this.deleteExchangeRateBtn.Caption = "წაშლა";
            this.deleteExchangeRateBtn.Id = 2;
            this.deleteExchangeRateBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteExchangeRateBtn.ImageOptions.Image")));
            this.deleteExchangeRateBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteExchangeRateBtn.ImageOptions.LargeImage")));
            this.deleteExchangeRateBtn.Name = "deleteExchangeRateBtn";
            this.deleteExchangeRateBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.deleteExchangeRateBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteExchangeRateBtn_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(784, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 402);
            // 
            // ExchangeRatesControl
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
            this.Name = "ExchangeRatesControl";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeRatesGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExchangeRateDtoBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl exchangeRatesGridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addExchangeRateBtn;
        private DevExpress.XtraBars.BarButtonItem editExchangeRateBtn;
        private DevExpress.XtraBars.BarButtonItem deleteExchangeRateBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private System.Windows.Forms.BindingSource getExchangeRateDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeType;
        private DevExpress.XtraGrid.Columns.GridColumn colScore;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
    }
}

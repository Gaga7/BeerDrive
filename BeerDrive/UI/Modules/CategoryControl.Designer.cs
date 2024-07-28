
namespace BeerDrive.UI.Modules
{
    partial class CategoryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.categoriesGridview = new DevExpress.XtraGrid.GridControl();
            this.getCategoryDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addCategoryBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCategoryBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCategoryDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.categoriesGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(963, 536);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // categoriesGridview
            // 
            this.categoriesGridview.DataSource = this.getCategoryDtoBindingSource;
            this.categoriesGridview.Location = new System.Drawing.Point(12, 12);
            this.categoriesGridview.MainView = this.gridView1;
            this.categoriesGridview.Name = "categoriesGridview";
            this.categoriesGridview.Size = new System.Drawing.Size(939, 512);
            this.categoriesGridview.TabIndex = 4;
            this.categoriesGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.categoriesGridview.Load += new System.EventHandler(this.CategoriesGridview_Load);
            // 
            // getCategoryDtoBindingSource
            // 
            this.getCategoryDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetCategoryDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDescription,
            this.colDateCreated});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.categoriesGridview;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
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
            // colDescription
            // 
            this.colDescription.Caption = "აღწერა";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 94;
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
            this.colDateCreated.VisibleIndex = 2;
            this.colDateCreated.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(963, 536);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.categoriesGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(943, 516);
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
            this.addCategoryBtn,
            this.editCategoryBtn,
            this.deleteBtn,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.addCategoryBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.editCategoryBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Caption = "დამატება";
            this.addCategoryBtn.Id = 0;
            this.addCategoryBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addCategoryBtn.ImageOptions.Image")));
            this.addCategoryBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addCategoryBtn.ImageOptions.LargeImage")));
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddCategoryBtn_ItemClick);
            // 
            // editCategoryBtn
            // 
            this.editCategoryBtn.Caption = "რედაქტირება";
            this.editCategoryBtn.Id = 1;
            this.editCategoryBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editCategoryBtn.ImageOptions.Image")));
            this.editCategoryBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editCategoryBtn.ImageOptions.LargeImage")));
            this.editCategoryBtn.Name = "editCategoryBtn";
            this.editCategoryBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditCategoryBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "წაშლა";
            this.deleteBtn.Id = 2;
            this.deleteBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.Image")));
            this.deleteBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.ImageOptions.LargeImage")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBtn_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(963, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 566);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(963, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 536);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(963, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 536);
            // 
            // CategoryControl
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
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(963, 566);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCategoryDtoBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl categoriesGridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource getCategoryDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addCategoryBtn;
        private DevExpress.XtraBars.BarButtonItem editCategoryBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
    }
}

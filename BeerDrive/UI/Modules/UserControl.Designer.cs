
namespace BeerDrive.UI.Modules
{
    partial class UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.usersGridview = new DevExpress.XtraGrid.GridControl();
            this.userDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addUserBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editUserBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteUserBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ColStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.usersGridview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(854, 472);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // usersGridview
            // 
            this.usersGridview.DataSource = this.userDtoBindingSource;
            this.usersGridview.Location = new System.Drawing.Point(12, 12);
            this.usersGridview.MainView = this.gridView1;
            this.usersGridview.Name = "usersGridview";
            this.usersGridview.Size = new System.Drawing.Size(830, 448);
            this.usersGridview.TabIndex = 4;
            this.usersGridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.usersGridview.Load += new System.EventHandler(this.UsersGridview_Load);
            // 
            // userDtoBindingSource
            // 
            this.userDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.GetUserDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPersonalId,
            this.colFirstName,
            this.colLastName,
            this.colPosition,
            this.colDateCreated,
            this.ColStatus});
            this.gridView1.DetailHeight = 372;
            this.gridView1.GridControl = this.usersGridview;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 29;
            this.colId.Name = "colId";
            this.colId.Width = 107;
            // 
            // colPersonalId
            // 
            this.colPersonalId.Caption = "პირადი ნომერი";
            this.colPersonalId.FieldName = "PersonalId";
            this.colPersonalId.MinWidth = 29;
            this.colPersonalId.Name = "colPersonalId";
            this.colPersonalId.Visible = true;
            this.colPersonalId.VisibleIndex = 0;
            this.colPersonalId.Width = 107;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "სახელი";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.MinWidth = 29;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 107;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "გვარი";
            this.colLastName.FieldName = "LastName";
            this.colLastName.MinWidth = 29;
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 107;
            // 
            // colPosition
            // 
            this.colPosition.Caption = "პოზიცია";
            this.colPosition.FieldName = "Position";
            this.colPosition.MinWidth = 29;
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            this.colPosition.Width = 107;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "შექმნის თარიღი";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.MinWidth = 29;
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 5;
            this.colDateCreated.Width = 107;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(854, 472);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.usersGridview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(834, 452);
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
            this.addUserBtn,
            this.editUserBtn,
            this.deleteUserBtn,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.addUserBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.editUserBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteUserBtn, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBtn, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Caption = "დამატება";
            this.addUserBtn.Id = 0;
            this.addUserBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addUserBtn.ImageOptions.Image")));
            this.addUserBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addUserBtn.ImageOptions.LargeImage")));
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddUserBtn_ItemClick);
            // 
            // editUserBtn
            // 
            this.editUserBtn.Caption = "რედაქტირება";
            this.editUserBtn.Id = 1;
            this.editUserBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editUserBtn.ImageOptions.Image")));
            this.editUserBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editUserBtn.ImageOptions.LargeImage")));
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditUserBtn_ItemClick);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Caption = "წაშლა";
            this.deleteUserBtn.Id = 2;
            this.deleteUserBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserBtn.ImageOptions.Image")));
            this.deleteUserBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteUserBtn.ImageOptions.LargeImage")));
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteUserBtn_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(854, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 502);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(854, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 472);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(854, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 472);
            // 
            // ColStatus
            // 
            this.ColStatus.Caption = "სტატუსი";
            this.ColStatus.FieldName = "Status";
            this.ColStatus.MinWidth = 25;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.Visible = true;
            this.ColStatus.VisibleIndex = 4;
            this.ColStatus.Width = 94;
            // 
            // UserControl
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
            this.Name = "UserControl";
            this.Size = new System.Drawing.Size(854, 502);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDtoBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl usersGridview;
        private System.Windows.Forms.BindingSource userDtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addUserBtn;
        private DevExpress.XtraBars.BarButtonItem editUserBtn;
        private DevExpress.XtraBars.BarButtonItem deleteUserBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraGrid.Columns.GridColumn ColStatus;
    }
}

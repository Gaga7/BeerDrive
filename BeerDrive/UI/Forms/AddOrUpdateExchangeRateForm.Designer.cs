
namespace BeerDrive.UI.Forms
{
    partial class AddOrUpdateExchangeRateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrUpdateExchangeRateForm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ExchangeTypeCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.setExchangeRateDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ScoreSpn = new DevExpress.XtraEditors.SpinEdit();
            this.AmountSpn = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForExchangeTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForScore = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.saveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeTypeCmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setExchangeRateDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreSpn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExchangeTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ExchangeTypeCmb);
            this.dataLayoutControl1.Controls.Add(this.ScoreSpn);
            this.dataLayoutControl1.Controls.Add(this.AmountSpn);
            this.dataLayoutControl1.DataSource = this.setExchangeRateDtoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(298, 112);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ExchangeTypeCmb
            // 
            this.ExchangeTypeCmb.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setExchangeRateDtoBindingSource, "ExchangeTypeId", true));
            this.ExchangeTypeCmb.Location = new System.Drawing.Point(52, 12);
            this.ExchangeTypeCmb.Name = "ExchangeTypeCmb";
            this.ExchangeTypeCmb.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ExchangeTypeCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExchangeTypeCmb.Size = new System.Drawing.Size(234, 22);
            this.ExchangeTypeCmb.StyleController = this.dataLayoutControl1;
            this.ExchangeTypeCmb.TabIndex = 4;
            // 
            // setExchangeRateDtoBindingSource
            // 
            this.setExchangeRateDtoBindingSource.DataSource = typeof(BeerDrive.DTOs.SetExchangeRateDto);
            // 
            // ScoreSpn
            // 
            this.ScoreSpn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setExchangeRateDtoBindingSource, "Score", true));
            this.ScoreSpn.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ScoreSpn.Location = new System.Drawing.Point(52, 38);
            this.ScoreSpn.Name = "ScoreSpn";
            this.ScoreSpn.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ScoreSpn.Properties.Appearance.Options.UseTextOptions = true;
            this.ScoreSpn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ScoreSpn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ScoreSpn.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.ScoreSpn.Properties.Mask.EditMask = "n0";
            this.ScoreSpn.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ScoreSpn.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ScoreSpn.Size = new System.Drawing.Size(234, 24);
            this.ScoreSpn.StyleController = this.dataLayoutControl1;
            this.ScoreSpn.TabIndex = 5;
            // 
            // AmountSpn
            // 
            this.AmountSpn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.setExchangeRateDtoBindingSource, "Amount", true));
            this.AmountSpn.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpn.Location = new System.Drawing.Point(52, 66);
            this.AmountSpn.Name = "AmountSpn";
            this.AmountSpn.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.AmountSpn.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountSpn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountSpn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AmountSpn.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.AmountSpn.Properties.Mask.EditMask = "n0";
            this.AmountSpn.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountSpn.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.AmountSpn.Size = new System.Drawing.Size(234, 24);
            this.AmountSpn.StyleController = this.dataLayoutControl1;
            this.AmountSpn.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(298, 112);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForExchangeTypeId,
            this.ItemForScore,
            this.ItemForAmount});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(278, 92);
            // 
            // ItemForExchangeTypeId
            // 
            this.ItemForExchangeTypeId.Control = this.ExchangeTypeCmb;
            this.ItemForExchangeTypeId.Location = new System.Drawing.Point(0, 0);
            this.ItemForExchangeTypeId.Name = "ItemForExchangeTypeId";
            this.ItemForExchangeTypeId.Size = new System.Drawing.Size(278, 26);
            this.ItemForExchangeTypeId.Text = "ტიპი";
            this.ItemForExchangeTypeId.TextSize = new System.Drawing.Size(37, 17);
            // 
            // ItemForScore
            // 
            this.ItemForScore.Control = this.ScoreSpn;
            this.ItemForScore.Location = new System.Drawing.Point(0, 26);
            this.ItemForScore.Name = "ItemForScore";
            this.ItemForScore.Size = new System.Drawing.Size(278, 28);
            this.ItemForScore.Text = "ქულა";
            this.ItemForScore.TextSize = new System.Drawing.Size(37, 17);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpn;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 54);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(278, 38);
            this.ItemForAmount.Text = "თანხა";
            this.ItemForAmount.TextSize = new System.Drawing.Size(37, 17);
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
            this.bar3.Offset = 187;
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
            this.barDockControlTop.Size = new System.Drawing.Size(298, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 112);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(298, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 112);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(298, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 112);
            // 
            // AddOrUpdateExchangeRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 144);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdateExchangeRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrUpdateExchangeRateForm";
            this.Load += new System.EventHandler(this.AddOrUpdateExchangeRateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeTypeCmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setExchangeRateDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreSpn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExchangeTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource setExchangeRateDtoBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit ExchangeTypeCmb;
        private DevExpress.XtraEditors.SpinEdit ScoreSpn;
        private DevExpress.XtraEditors.SpinEdit AmountSpn;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExchangeTypeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForScore;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem saveBtn;
        private DevExpress.XtraBars.BarButtonItem cancelBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
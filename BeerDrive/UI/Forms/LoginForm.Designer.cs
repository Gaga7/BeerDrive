
namespace BeerDrive.UI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.loginBtn = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.loginNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.closeBtn);
            this.layoutControl1.Controls.Add(this.loginBtn);
            this.layoutControl1.Controls.Add(this.passwordTxt);
            this.layoutControl1.Controls.Add(this.loginNameTxt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(313, 114);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.ImageOptions.Image")));
            this.closeBtn.Location = new System.Drawing.Point(220, 64);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.closeBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.closeBtn.Size = new System.Drawing.Size(81, 27);
            this.closeBtn.StyleController = this.layoutControl1;
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "დახურვა";
            // 
            // loginBtn
            // 
            this.loginBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.ImageOptions.Image")));
            this.loginBtn.Location = new System.Drawing.Point(144, 64);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.loginBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.loginBtn.Size = new System.Drawing.Size(72, 27);
            this.loginBtn.StyleController = this.layoutControl1;
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "შესვლა";
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.EditValue = "";
            this.passwordTxt.Location = new System.Drawing.Point(106, 38);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Properties.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(195, 22);
            this.passwordTxt.StyleController = this.layoutControl1;
            this.passwordTxt.TabIndex = 5;
            // 
            // loginNameTxt
            // 
            this.loginNameTxt.EditValue = "";
            this.loginNameTxt.Location = new System.Drawing.Point(106, 12);
            this.loginNameTxt.Name = "loginNameTxt";
            this.loginNameTxt.Size = new System.Drawing.Size(195, 22);
            this.loginNameTxt.StyleController = this.layoutControl1;
            this.loginNameTxt.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(313, 114);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.loginNameTxt;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(293, 26);
            this.layoutControlItem1.Text = "მომხმარებელი";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(132, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.passwordTxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(293, 26);
            this.layoutControlItem2.Text = "პაროლი";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.loginBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(132, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(76, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.closeBtn;
            this.layoutControlItem4.Location = new System.Drawing.Point(208, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(85, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(313, 114);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.TextEdit loginNameTxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
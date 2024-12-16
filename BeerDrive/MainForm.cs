using BeerDrive.Global;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
                {
                    if (!fluentDesignFormContainer.Controls.ContainsKey(module.Name))
                    {
                        var control = module.TModule as TutorialControlBase;
                        if (control != null)
                        {
                            control.Dock = DockStyle.Fill;

                            fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                fluentDesignFormContainer.Controls.Add(control);
                                control.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var control = fluentDesignFormContainer.Controls.Find(module.Name, true);
                        if (control.Length == 1)
                            fluentDesignFormContainer.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                    }
                });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializePermissions();

            if (Globals.User.IsOperator)
                LoadTerminal();
        }

        private async void LoadTerminal()
        {
            await InitializeControl("TerminalControl");

            accordionControl.OptionsMinimizing.State = AccordionControlState.Minimized;
        }

        private void InitializePermissions()
        {
            accordionControlElementTerminal.Visible = Globals.User.IsAdmin || Globals.User.IsOperator;
            accordionControlElementCategories.Visible = Globals.User.IsAdmin;
            accordionControlElementProducts.Visible = Globals.User.IsAdmin || Globals.User.IsManager;
            accordionControlElementUsers.Visible = Globals.User.IsAdmin;
            accordionControlElementCustomers.Visible = Globals.User.IsAdmin || Globals.User.IsOperator || Globals.User.IsManager;
            accordionControlElementOrders.Visible = Globals.User.IsAdmin || Globals.User.IsOperator;
            accordionControlElementOrderDetails.Visible = Globals.User.IsAdmin || Globals.User.IsOperator;
            accordionControlElementSuppliers.Visible = Globals.User.IsAdmin;
            accordionControlElementRoles.Visible = Globals.User.IsAdmin;
            accordionControlElementPositions.Visible = Globals.User.IsAdmin;
            accordionControlElementTransactions.Visible = Globals.User.IsAdmin || Globals.User.IsOperator;
            accordionControlElementTransactionDetails.Visible = Globals.User.IsAdmin || Globals.User.IsOperator;
        }

        private async Task InitializeControl(string control)
        {
            if (ModulesInfo.GetItem(control) == null)
                ModulesInfo.Add(new ModuleInfo(control, $"BeerDrive.UI.Modules.{control}"));

            await LoadModuleAsync(ModulesInfo.GetItem(control));
        }

        private async void AccordionControlElementCategories_Click(object sender, EventArgs e)
        {
            await InitializeControl("CategoryControl");
        }

        private async void AccordionControlElementProducts_Click(object sender, EventArgs e)
        {
            await InitializeControl("ProductControl");
        }

        private async void AccordionControlElementUsers_Click(object sender, EventArgs e)
        {
            await InitializeControl("UserControl");
        }

        private async void AccordionControlElementCustomers_Click(object sender, EventArgs e)
        {
            await InitializeControl("CustomerControl");
        }

        private async void AccordionControlElementOrders_Click(object sender, EventArgs e)
        {
            await InitializeControl("OrderControl");
        }

        private async void AccordionControlElementOrderDetails_Click(object sender, EventArgs e)
        {
            await InitializeControl("OrderDetailControl");
        }

        private async void AccordionControlElementTerminal_Click(object sender, EventArgs e)
        {
            await InitializeControl("TerminalControl");
        }

        private async void AccordionControlElementSuppliers_Click(object sender, EventArgs e)
        {
            await InitializeControl("SupplierControl");
        }

        private async void AccordionControlElementRoles_Click(object sender, EventArgs e)
        {
            await InitializeControl("RoleControl");
        }

        private async void AccordionControlElementPositions_Click(object sender, EventArgs e)
        {
            await InitializeControl("PositionControl");
        }

        private async void AccordionControlElementTransactions_Click(object sender, EventArgs e)
        {
            await InitializeControl("TransactionControl");
        }

        private async void AccordionControlElementTransactionDetails_Click(object sender, EventArgs e)
        {
            await InitializeControl("TransactionDetailsControl");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            if (XtraMessageBox.Show("დარწმუნებული ხართ რომ გსურთ პროგრამის დახურვა?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}

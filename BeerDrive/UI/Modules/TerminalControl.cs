using BeerDrive.DAL.Enums;
using BeerDrive.DTOs;
using BeerDrive.Global;
using BeerDrive.Presenters;
using BeerDrive.UI.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Modules
{
    public partial class TerminalControl : TutorialControlBase
    {
        private static readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        private PayTypePresenter payTypePresenter;
        private ProductPresenter productPresenter;
        private TerminalPresenter terminalPresenter;
        private TransactionPresenter transactionPresenter;
        private TransactionDetailPresenter transactionDetailPresenter;

        public PayTypePresenter PayTypePresenter
        {
            get
            {
                if (payTypePresenter == null)
                    payTypePresenter = new PayTypePresenter();

                return payTypePresenter;
            }
        }

        public ProductPresenter ProductPresenter
        {
            get
            {
                if (productPresenter == null)
                    productPresenter = new ProductPresenter();

                return productPresenter;
            }
        }

        public TerminalPresenter TerminalPresenter
        {
            get
            {
                if (terminalPresenter == null)
                    terminalPresenter = new TerminalPresenter();

                return terminalPresenter;
            }
        }

        public TransactionPresenter TransactionPresenter
        {
            get
            {
                if (transactionPresenter == null)
                    transactionPresenter = new TransactionPresenter();

                return transactionPresenter;
            }
        }

        public TransactionDetailPresenter TransactionDetailPresenter
        {
            get
            {
                if (transactionDetailPresenter == null)
                    transactionDetailPresenter = new TransactionDetailPresenter();

                return transactionDetailPresenter;
            }
        }

        private Guid? TransactionId;

        public decimal Change
        {
            get { return changeSpn.Value; }
            set { changeSpn.Value = value; }
        }

        public decimal Cash
        {
            get { return cashSpn.Value; }
            set { cashSpn.Value = value; }
        }

        public bool CashEnabled
        {
            get { return !cashSpn.ReadOnly; }
            set { cashSpn.ReadOnly = !value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmountSpn.Value; }
            set { totalAmountSpn.Value = value; }
        }

        public decimal Quantity
        {
            get { return quantitySpn.Value; }
            set { quantitySpn.Value = value; }
        }

        public decimal TotalQuantity
        {
            get { return totalQuantitySpn.Value; }
            set { totalQuantitySpn.Value = value; }
        }

        public string Barcode
        {
            get { return barcodeTxt.Text; }
            set { barcodeTxt.Text = value; }
        }

        public Guid? PayTypeId
        {
            get { return (Guid?)payTypeRg.EditValue; }
            set { payTypeRg.EditValue = value; }
        }

        public TerminalControl()
        {
            InitializeComponent();
        }

        private void TerminalControl_Load(object sender, EventArgs e)
        {
            FillPayTypes();
            FillTerminal();
            InitializePermissions();
        }

        private async void FillPayTypes()
        {
            var payTypes = await PayTypePresenter.GetAsync();
            var datasource = payTypes.Select(s => new RadioGroupItem(s.Id, s.Name)).ToArray();

            payTypeRg.Properties.Items.AddRange(datasource);
        }

        private async void FillTerminal()
        {
            SetFocus(barcodeTxt);

            var model = TransactionId == null ? await TerminalPresenter.GetLastActiveAsync() : await TerminalPresenter.GetAsync(TransactionId.Value);

            if (model != null)
                TransactionId = model.Transaction.Id;

            if (TransactionId == null)
                return;

            getTransactionDetailDtoBindingSource.DataSource = model.TransactionDetails;

            TotalQuantity = model.TransactionDetails.Sum(s => s.Quantity);
            TotalAmount = model.TransactionDetails.Sum(s => s.TotalPrice);

            //Barcode = null;
        }

        private void InitializePermissions()
        {
            //layoutControlItemDeleteBtn.ContentVisible = Globals.User.IsAdmin;
            //layoutControlItemCancelBtn.ContentVisible = Globals.User.IsAdmin;
        }

        private async void BarcodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            await semaphoreSlim.WaitAsync();

            try
            {
                await SearchBarcode();
            }
            finally
            {
                semaphoreSlim.Release();
            }
        }

        private async Task SearchBarcode()
        {
            if (string.IsNullOrEmpty(Barcode))
            {
                XtraMessageBox.Show("მიუთითეთ ბარკოდი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var products = await ProductPresenter.GetAsync(r => r.Barcode == Barcode);

            Barcode = null;
            Quantity = 0;

            if (products == null || !products.Any())
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (products.Count() > 1)
            {
                XtraMessageBox.Show("მოიძებნა ერთზე მეტი ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = products.First();

            decimal unitPrice = 0;
            if (product.SetPriceDuringSell)
            {
                var form = new SetPriceForm();

                if (form.ShowDialog() != DialogResult.OK)
                    return;

                unitPrice = form.UnitPrice;
            }

            if (TransactionId == null)
            {
                var model = new SetTerminalDto
                {
                    TransactionNumber = await terminalPresenter.GenerateTransactionNumber(),
                    TransactionDetail = new SetTransactionDetailDto
                    {
                        ProductId = product.Id,
                        Quantity = 1,
                        UnitPrice = unitPrice
                    }
                };

                TransactionId = await terminalPresenter.CreateAsync(model);
            }
            else
            {
                var transactionDetails = await TransactionDetailPresenter.GetAsync(c => c.TransactionId == TransactionId.Value && c.ProductId == product.Id && (c.UnitPrice == unitPrice || !product.SetPriceDuringSell));

                if (transactionDetails.Count() > 1)
                {
                    XtraMessageBox.Show("მოიძებნა ერთზე მეტი ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (transactionDetails.Any())
                {
                    var transactionDetail = transactionDetails.First();

                    await TransactionDetailPresenter.UpdateQuantityAsync(transactionDetail.Id, transactionDetail.Quantity + 1);
                }
                else
                {
                    var model = new SetTransactionDetailDto
                    {
                        TransactionId = TransactionId,
                        ProductId = product.Id,
                        Quantity = 1,
                        UnitPrice = unitPrice
                    };

                    await TransactionDetailPresenter.CreateAsync(model);
                }
            }

            //Barcode = null;
            //Quantity = 0;

            FillTerminal();
        }

        private void CashSpn_ValueChanged(object sender, EventArgs e)
        {
            RecalculateChange();
        }

        private void TotalAmountSpn_ValueChanged(object sender, EventArgs e)
        {
            RecalculateChange();
        }

        private void RecalculateChange()
        {
            Change = 0;

            if (Cash == 0)
                return;

            Change = Cash - TotalAmount;
        }

        private void PayTypeRg_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFocus(barcodeTxt);

            CashEnabled = PayTypeId == PayTypesEnum.Cash;

            if (!CashEnabled)
                Cash = 0;
        }

        private async void PayBtn_Click(object sender, EventArgs e)
        {
            SetFocus(barcodeTxt);

            if (XtraMessageBox.Show("მონაცემები დაფიქსირდება ბაზაში. გავაგრძელოთ?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var model = new SetPayDto
            {
                Id = TransactionId,
                PayTypeId = PayTypeId,
                Cash = Cash,
                Change = Change
            };

            await TerminalPresenter.PayAsync(model);

            Clear();
            FillTerminal();
        }

        private void Clear()
        {
            TransactionId = null;
            PayTypeId = null;
            getTransactionDetailDtoBindingSource.Clear();
            TotalQuantity = 0;
            TotalAmount = 0;
            Cash = 0;
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            SetFocus(barcodeTxt);

            var selected = ((GridView)transactionDetailsGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetTransactionDetailDto)((GridView)transactionDetailsGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var transactionDetail = await TransactionDetailPresenter.GetAsync(selectedRow.Id);
            if (transactionDetail == null)
            {
                XtraMessageBox.Show("ჩანაწერი ვერ მოიძებნა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await TransactionDetailPresenter.UpdateQuantityAsync(transactionDetail.Id, Quantity);

            Quantity = 0;
            Barcode = null;

            FillTerminal();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            SetFocus(barcodeTxt);

            var selected = ((GridView)transactionDetailsGridview.MainView).GetSelectedRows();
            if (selected == null || !selected.Any())
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = (GetTransactionDetailDto)((GridView)transactionDetailsGridview.MainView).GetRow(selected[0]);
            if (selectedRow == null)
            {
                XtraMessageBox.Show("მონიშნეთ ჩანაწერი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის წაშლა?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.User.IsOperator)
                {
                    await TransactionDetailPresenter.SendCodeToEmailAsync(selectedRow.Id);

                    var form = new OneTimeCodeForm(selectedRow.Id, OneTimeCodeTypesEnum.TransactionDetail);

                    if (form.ShowDialog() != DialogResult.OK)
                        return;
                }

                await TransactionDetailPresenter.DeleteAsync(selectedRow.Id);

                FillTerminal();
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillTerminal();
        }

        private void TransactionDetailsGridview_Click(object sender, EventArgs e)
        {
            SetFocus(barcodeTxt);
        }

        private void TransactionDetailsGridview_DoubleClick(object sender, EventArgs e)
        {
            SetFocus(barcodeTxt);
        }

        private void SetFocus(Control control)
        {
            control.Focus();
        }

        private async void AddInQueueBtn_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("ნამდვილად გსურთ ჩანაწერის რიგში ჩაბრუნება?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            await TerminalPresenter.AddInQueueAsync(TransactionId);

            Clear();
            FillTerminal();
        }

        private async void CancelBtn_Click(object sender, EventArgs e)
        {
            if (TransactionId == null)
            {
                XtraMessageBox.Show("ტრანზაქციის იდენტიფიკატორი ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("ნამდვილად გსურთ ტრანზაქციის გაუქმება?", "შეტყობინება", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (Globals.User.IsOperator)
            {
                await TransactionPresenter.SendCodeToEmailAsync(TransactionId);

                var form = new OneTimeCodeForm(TransactionId.Value, OneTimeCodeTypesEnum.Transaction);

                if (form.ShowDialog() != DialogResult.OK)
                    return;
            }

            await TerminalPresenter.CancelAsync(TransactionId);

            Clear();
            FillTerminal();
        }

        //private string _barcode = "";
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    char c = (char)keyData;

        //    if (char.IsNumber(c))
        //        _barcode += c;

        //    if (c == (char)Keys.Return)
        //    {
        //        //var enter = new KeyPressEventArgs((char)Keys.Enter);

        //        //Barcode = "";
        //        //BarcodeTxt_KeyPress(null, enter);

        //        //Task.Run(async () => await SearchBarcode());

        //        Quantity = 0;
        //        Cash = 0;

        //        SetFocus(barcodeTxt);
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
    }
}

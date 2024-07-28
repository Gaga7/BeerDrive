using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateOrderForm : XtraForm
    {
        private ProductPresenter productPresenter;
        private UserPresenter userPresenter;
        private OrderPresenter orderPresenter;
        private OrderDetailPresenter orderDetailPresenter;

        public ProductPresenter ProductPresenter
        {
            get
            {
                if (productPresenter == null)
                    productPresenter = new ProductPresenter();

                return productPresenter;
            }
        }

        public UserPresenter UserPresenter
        {
            get
            {
                if (userPresenter == null)
                    userPresenter = new UserPresenter();

                return userPresenter;
            }
        }

        public OrderPresenter OrderPresenter
        {
            get
            {
                if (orderPresenter == null)
                    orderPresenter = new OrderPresenter();

                return orderPresenter;
            }
        }

        public OrderDetailPresenter OrderDetailPresenter
        {
            get
            {
                if (orderDetailPresenter == null)
                    orderDetailPresenter = new OrderDetailPresenter();

                return orderDetailPresenter;
            }
        }

        public Guid? UserId
        {
            get
            {
                var selected = userCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
        }

        public DateTime? OrderDate => (DateTime?)orderDateDe.EditValue;

        public Guid? ProductId
        {
            get
            {
                var selected = productCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set => SetValue(productCmb, value);
        }

        public string NameOfProduct
        {
            get
            {
                var selected = productCmb.SelectedItem as ImageListBoxItem;
                return selected?.Description;
            }
        }

        public decimal? Quantity
        {
            get => quantitySpn.Value;
            private set => quantitySpn.Value = value ?? 0;
        }

        public decimal? UnitPrice
        {
            get => unitPriceSpn.Value;
            private set => unitPriceSpn.Value = value ?? 0;
        }

        public decimal? TotalPrice
        {
            get => totalPriceSpn.Value;
            private set => totalPriceSpn.Value = value ?? 0;
        }

        public decimal? Discount
        {
            get => discountSpn.Value;
            private set => discountSpn.Value = value ?? 0;
        }

        private readonly Guid _supplierId;
        private List<GetOrderDetailDto> orderDetails;

        public AddOrUpdateOrderForm(Guid supplierId)
        {
            InitializeComponent();

            _supplierId = supplierId;
        }

        private void AddOrUpdateOrderForm_Load(object sender, EventArgs e)
        {
            if (orderDetails == null)
                orderDetails = new List<GetOrderDetailDto>();

            FillProducts();
            FillUsers();
        }

        private void SetValue(ComboBoxEdit control, Guid? value)
        {
            foreach (ImageListBoxItem item in control.Properties.Items)
            {
                if ((Guid?)item.Value == value)
                {
                    control.SelectedItem = item;
                    return;
                }
            }
        }

        private async void FillProducts()
        {
            var entities = await ProductPresenter.GetAsync(r => r.SupplierId == _supplierId);
            var datasource = entities.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            productCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            productCmb.Properties.Items.AddRange(datasource);

            productCmb.SelectedIndex = 0;
        }

        private async void FillUsers()
        {
            var entities = await UserPresenter.GetAsync();
            var datasource = entities.Select(s => new ImageListBoxItem(s.Id, $"{s.FirstName} {s.LastName}")).ToList();

            userCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            userCmb.Properties.Items.AddRange(datasource);

            userCmb.SelectedIndex = 0;
        }

        private void BindOrderDetails()
        {
            getOrderDetailDtoBindingSource.ResetBindings(true);
            getOrderDetailDtoBindingSource.DataSource = orderDetails;
        }

        private async void SaveOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var list = new List<SetOrderDetailDto>();

            foreach (var item in orderDetails)
            {
                var orderDetailModel = new SetOrderDetailDto
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    TotalPrice = item.TotalPrice,
                    Discount = item.Discount
                };

                list.Add(orderDetailModel);
            }

            var orderModel = new SetOrderDto
            {
                UserId = UserId,
                OrderDate = OrderDate,
                OrderDetails = list
            };

            await OrderPresenter.CreateAsync(orderModel);

            DialogResult = DialogResult.OK;
        }

        private void CloseOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => Close();

        private void AddOrderDetailBtn_Click(object sender, EventArgs e)
        {
            if (ProductId == null)
            {
                XtraMessageBox.Show("აირჩიეთ პროდუქტი", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Quantity.GetValueOrDefault() <= 0)
            {
                XtraMessageBox.Show("რაოდენობა ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UnitPrice == null)
            {
                XtraMessageBox.Show("ფასი ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TotalPrice == null)
            {
                XtraMessageBox.Show("თანხა (სულ) ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Discount == null)
            {
                XtraMessageBox.Show("ფასდაკლება ცარიელია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (orderDetails.Any(a => a.ProductId == ProductId))
            {
                XtraMessageBox.Show("პროდუქტი უკვე დამატებულია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var model = new GetOrderDetailDto
            {
                Id = Guid.NewGuid(),
                ProductId = ProductId,
                ProductName = NameOfProduct,
                UnitPrice = UnitPrice,
                TotalPrice = TotalPrice,
                Quantity = Quantity,
                Discount = Discount,
            };

            orderDetails.Add(model);

            BindOrderDetails();

            Clear();
        }

        private void EditOrderDetailBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteOrderDetailBtn_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            ProductId = null;
            Quantity = 0;
            UnitPrice = 0;
            TotalPrice = 0;
            Discount = 0;
        }
    }
}

using BeerDrive.Presenters;
using BeerDrive.UI.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerDrive.UI.Modules
{
    public partial class OrderControl : TutorialControlBase
    {
        private OrderPresenter orderPresenter;
        public OrderPresenter OrderPresenter
        {
            get
            {
                if (orderPresenter == null)
                    orderPresenter = new OrderPresenter();

                return orderPresenter;
            }
        }

        public OrderControl()
        {
            InitializeComponent();
        }

        private async void OrdersGridview_Load(object sender, EventArgs e)
        {
            await BindOrders();
        }

        private async Task BindOrders()
        {
            getOrderDtoBindingSource.DataSource = await OrderPresenter.GetAsync();
        }

        private async void AddOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var supplierChooseForm = new SupplierChooseForm();
            if (supplierChooseForm.ShowDialog() == DialogResult.OK)
            {
                if (supplierChooseForm.SupplierId == null)
                {
                    XtraMessageBox.Show("აირჩიეთ ორგანიზაცია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var form = new AddOrUpdateOrderForm(supplierChooseForm.SupplierId.Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    XtraMessageBox.Show("ოპერაცია წარმატებით განხორციელდა", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await BindOrders();
                }
            }
        }

        private void EditOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void DeleteOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindOrders();
        }
    }
}

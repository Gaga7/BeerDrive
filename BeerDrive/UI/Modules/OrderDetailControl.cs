using BeerDrive.Presenters;
using DevExpress.DXperience.Demos;
using System;
using System.Threading.Tasks;

namespace BeerDrive.UI.Modules
{
    public partial class OrderDetailControl : TutorialControlBase
    {
        private OrderDetailPresenter orderDetailPresenter;
        public OrderDetailPresenter OrderDetailPresenter
        {
            get
            {
                if (orderDetailPresenter == null)
                    orderDetailPresenter = new OrderDetailPresenter();

                return orderDetailPresenter;
            }
        }

        public OrderDetailControl()
        {
            InitializeComponent();
        }

        private async void OrderDetailsGridview_Load(object sender, EventArgs e)
        {
            await BindOrderDetails();
        }

        private async Task BindOrderDetails()
        {
            getOrderDetailDtoBindingSource.DataSource = await OrderDetailPresenter.GetAsync();
        }

        private async void RefreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await BindOrderDetails();
        }
    }
}

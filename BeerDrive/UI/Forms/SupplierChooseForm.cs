using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class SupplierChooseForm : XtraForm
    {
        private SupplierPresenter supplierPresenter;

        public SupplierPresenter SupplierPresenter
        {
            get
            {
                if (supplierPresenter == null)
                    supplierPresenter = new SupplierPresenter();

                return supplierPresenter;
            }
        }

        public Guid? SupplierId
        {
            get
            {
                var selected = SupplierCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
        }

        public SupplierChooseForm()
        {
            InitializeComponent();
        }

        private void SupplierChooseForm_Load(object sender, EventArgs e)
        {
            FillSuppliers();
        }

        private async void FillSuppliers()
        {
            var suppliers = await SupplierPresenter.GetAsync();
            var datasource = suppliers.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            SupplierCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            SupplierCmb.Properties.Items.AddRange(datasource);

            SupplierCmb.SelectedIndex = 0;
        }

        private void SaveSupplierBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SupplierId == null)
            {
                XtraMessageBox.Show("აირჩიეთ ორგანიზაცია", "შეტყობინება", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void CloseSupplierBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

using BeerDrive.DTOs;
using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateProductForm : XtraForm
    {
        private CategoryPresenter categoryPresenter;
        private ProductPresenter productPresenter;
        private SupplierPresenter supplierPresenter;
        private MeasureUnitTypePresenter measureUnitTypePresenter;

        public CategoryPresenter CategoryPresenter
        {
            get
            {
                if (categoryPresenter == null)
                    categoryPresenter = new CategoryPresenter();

                return categoryPresenter;
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

        public SupplierPresenter SupplierPresenter
        {
            get
            {
                if (supplierPresenter == null)
                    supplierPresenter = new SupplierPresenter();

                return supplierPresenter;
            }
        }

        public MeasureUnitTypePresenter MeasureUnitTypePresenter
        {
            get
            {
                if (measureUnitTypePresenter == null)
                    measureUnitTypePresenter = new MeasureUnitTypePresenter();

                return measureUnitTypePresenter;
            }
        }

        private readonly Guid? _id;

        public string NameOfProduct
        {
            get => NameTxt.Text;
            private set => NameTxt.Text = value;
        }

        public string Barcode
        {
            get => BarcodeTxt.Text;
            private set => BarcodeTxt.Text = value;
        }

        public Guid? CategoryId
        {
            get
            {
                var selected = CategoryCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set => SetValue(CategoryCmb, value);
        }

        public Guid? SupplierId
        {
            get
            {
                var selected = SupplierCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set => SetValue(SupplierCmb, value);
        }

        public decimal UnitInStock
        {
            get => UnitInStockSpn.Value;
            private set => UnitInStockSpn.Value = value;
        }

        public decimal UnitPrice
        {
            get => UnitPriceSpn.Value;
            private set => UnitPriceSpn.Value = value;
        }

        public Guid? MeasureUnitTypeId
        {
            get
            {
                var selected = MeasureUnitTypeCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set
            {
                SetValue(MeasureUnitTypeCmb, value);
            }
        }

        public bool DisableCheckInStock
        {
            get => DisableCheckInStockCheckEdit.Checked;
            private set => DisableCheckInStockCheckEdit.Checked = value;
        }

        public bool SetPriceDuringSell
        {
            get => SetPriceDuringSellCheckEdit.Checked;
            private set => SetPriceDuringSellCheckEdit.Checked = value;
        }

        public AddOrUpdateProductForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateProductForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdateProductForm_Load(object sender, EventArgs e)
        {
            FillCategories();
            FillSuppliers();
            FillMeasureUnitTypes();
            FillProduct();
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

        private async void FillCategories()
        {
            var categories = await CategoryPresenter.GetAsync();
            var datasource = categories.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            CategoryCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            CategoryCmb.Properties.Items.AddRange(datasource);

            CategoryCmb.SelectedIndex = 0;
        }

        private async void FillSuppliers()
        {
            var suppliers = await SupplierPresenter.GetAsync();
            var datasource = suppliers.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            SupplierCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            SupplierCmb.Properties.Items.AddRange(datasource);

            SupplierCmb.SelectedIndex = 0;
        }

        private async void FillMeasureUnitTypes()
        {
            var measureUnitTypes = await MeasureUnitTypePresenter.GetAsync();
            var datasource = measureUnitTypes.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            MeasureUnitTypeCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            MeasureUnitTypeCmb.Properties.Items.AddRange(datasource);

            MeasureUnitTypeCmb.SelectedIndex = 0;
        }

        private async void FillProduct()
        {
            if (_id == null)
                return;

            var entity = await ProductPresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            NameOfProduct = entity.Name;
            Barcode = entity.Barcode;
            UnitInStock = entity.UnitInStock;
            UnitPrice = entity.UnitPrice;
            CategoryId = entity.CategoryId;
            SupplierId = entity.SupplierId;
            MeasureUnitTypeId = entity.MeasureUnitTypeId;
            DisableCheckInStock = entity.DisableCheckInStock;
            SetPriceDuringSell = entity.SetPriceDuringSell;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetProductDto
            {
                Name = NameOfProduct,
                Barcode = Barcode,
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                MeasureUnitTypeId = MeasureUnitTypeId,
                UnitInStock = UnitInStock,
                UnitPrice = UnitPrice,
                DisableCheckInStock = DisableCheckInStock,
                SetPriceDuringSell = SetPriceDuringSell
            };

            if (_id == null)
                await ProductPresenter.CreateAsync(model);
            else
                await ProductPresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

using BeerDrive.Presenters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;
using System.Linq;
using BeerDrive.DTOs;

namespace BeerDrive.UI.Forms
{
    public partial class AddOrUpdateExchangeRateForm : XtraForm
    {
        private ExchangeRatePresenter exchangeRatePresenter;
        private ExchangeTypePresenter exchangeTypePresenter;

        public ExchangeRatePresenter ExchangeRatePresenter
        {
            get
            {
                if (exchangeRatePresenter == null)
                    exchangeRatePresenter = new ExchangeRatePresenter();

                return exchangeRatePresenter;
            }
        }

        public ExchangeTypePresenter ExchangeTypePresenter
        {
            get
            {
                if (exchangeTypePresenter == null)
                    exchangeTypePresenter = new ExchangeTypePresenter();

                return exchangeTypePresenter;
            }
        }

        public Guid? ExchangeTypeId
        {
            get
            {
                var selected = ExchangeTypeCmb.SelectedItem as ImageListBoxItem;
                return (Guid?)selected?.Value;
            }
            private set => SetValue(ExchangeTypeCmb, value);
        }

        public decimal Score
        {
            get => ScoreSpn.Value;
            private set => ScoreSpn.Value = value;
        }

        public decimal Amount
        {
            get => AmountSpn.Value;
            private set => AmountSpn.Value = value;
        }

        private readonly Guid? _id;

        public AddOrUpdateExchangeRateForm()
        {
            InitializeComponent();
        }

        public AddOrUpdateExchangeRateForm(Guid id) : this()
        {
            _id = id;
        }

        private void AddOrUpdateExchangeRateForm_Load(object sender, EventArgs e)
        {
            FillExchangeTypes();
            Fill();
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

        private async void FillExchangeTypes()
        {
            var exchangeTypes = await ExchangeTypePresenter.GetAsync();
            var datasource = exchangeTypes.Select(s => new ImageListBoxItem(s.Id, s.Name)).ToList();

            ExchangeTypeCmb.Properties.Items.Add(new ImageListBoxItem(null, "გთხოვთ აირჩიოთ..."));
            ExchangeTypeCmb.Properties.Items.AddRange(datasource);

            ExchangeTypeCmb.SelectedIndex = 0;
        }

        private async void Fill()
        {
            if (_id == null)
                return;

            var entity = await ExchangeRatePresenter.GetAsync(_id.Value);
            if (entity == null)
                return;

            ExchangeTypeId = entity.ExchangeTypeId;
            Score = entity.Score;
            Amount = entity.Amount;
        }

        private async void SaveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var model = new SetExchangeRateDto()
            {
                ExchangeTypeId = ExchangeTypeId,
                Score = Score,
                Amount = Amount
            };

            if (_id == null)
                await ExchangeRatePresenter.CreateAsync(model);
            else
                await ExchangeRatePresenter.UpdateAsync(_id.Value, model);

            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}

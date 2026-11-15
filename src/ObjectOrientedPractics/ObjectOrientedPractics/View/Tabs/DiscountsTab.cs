using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private readonly PointsDiscount _discount = new PointsDiscount();
        private readonly PercentDiscount _discountPercent = new PercentDiscount(Category.toys);
        private BindingList<Item> _items = new BindingList<Item> { new Item("Тест", "info", 2999.9f, Category.toys) };

        public DiscountsTab()
        {
            InitializeComponent();
            GenerateItems();
        }

        /// <summary>
        /// Создаёт новый случайный набор товаров и показывает его сумму.
        /// </summary>
        private void GenerateItems()
        {
            labelProductsAmountCost.Text = _items.Sum(item => item.Cost).ToString("N2");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelDiscountAmountCost.Text = _discount.Calculate(_items).ToString("N2");
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            labelDiscountAmountCost.Text = _discount.Apply(_items).ToString("N2");
            labelInfo.Text = $"Баллов: {_discount.CountPoints}";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _discount.Update(_items);
            labelInfo.Text = $"Баллов: {_discount.CountPoints}";
        }



        private void buttonCalculateProcent_Click(object sender, EventArgs e)
        {
            labelDecoveryProcent.Text = _discountPercent.Calculate(_items).ToString("N2");
        }

        private void buttonUpdateProcent_Click(object sender, EventArgs e)
        {
            _discountPercent.Update(_items);
            labelProcent.Text = $"Процентная «{_discountPercent.Category}» - {_discountPercent.CurrentDiscount}%";
        }
    }
}

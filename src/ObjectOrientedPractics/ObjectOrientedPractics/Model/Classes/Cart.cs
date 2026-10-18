public class Cart
{
    /// <summary>
    /// Список товаров покупателя.
    /// </summary>
    public List<Item> Items { get; set; }

    /// <summary>
    /// Подсчет стоимости товаров в корзине покупателя.
    /// </summary>
    public double Amout
    {
        get
        {
            if (Items == null || Items.Count == 0)
            {
                return 0.0;
            }

            double sum = 0.0;
            foreach (Item item in Items)
            {
                sum += item.Cost;
            }

            return sum;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Cart"/>.
    /// </summary>
    /// <param name="items">Список товаров в корзине покупателя.</param>
    public Cart(List<Item> items)
    {
        Items = items;
    }
}
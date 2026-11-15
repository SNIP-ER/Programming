using System.ComponentModel;

public class PercentDiscount : IDiscount
{
    /// <summary>
    /// Наименьший размер скидки.
    /// </summary>
    private const int MinPercent = 1;
    /// <summary>
    /// Наибольший размер скидки.
    /// </summary>
    private const int MaxPercent = 10;
    /// <summary>
    /// Шаг суммы покупок, за который скидка вырастает на 1%.
    /// </summary>
    private const double StepAmount = 1000;

    /// <summary>
    /// Категории на которые распространяется скидка.
    /// </summary>
    public Category Category { get; }

    /// <summary>
    /// Текущий размер скидки.
    /// </summary>
    public int CurrentDiscount
    {
        get
        {
            int percent = MinPercent + (int)(CurrentAmount / StepAmount);
            return Math.Min(percent, MaxPercent);
        }
    }

    /// <summary>
    /// Текущая стоимость всех покупок покупателя нужной категории.
    /// </summary>
    public double CurrentAmount { get; private set; }


    /// <summary>
    /// Возвращает название скидки.
    /// </summary>
    public string Info
    {
        get
        {
            return $"Процентная «{Category}» - {CurrentDiscount}%";
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
    /// </summary>
    /// <param name="category">Категория товара, в которой действует скидка.</param>
    public PercentDiscount(Category category)
    {
        Category = category;
    }

    /// <summary>
    /// Возвращает размер скидки, доступной для этого списка продуктов.
    /// Вызывается перед оформлением заказа.
    /// </summary>
    /// <param name="items">Список продуктов.</param>
    /// <returns>Размер скидки.</returns>
    public double Calculate(BindingList<Item> items)
    {
        return GetDiscount(items);
    }

    /// <summary>
    /// Состояние не меняется.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Размер скидки.</returns>
    public double Apply(BindingList<Item> items)
    {
        return GetDiscount(items);
    }

    /// <summary>
    /// Увеличивает накопленную сумму покупок.
    /// Вызывается после каждой покупки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    public void Update(BindingList<Item> items)
    {
        CurrentAmount += GetCost(items);
    }

    /// <summary>
    /// Вычисление размера скидки для товаров своей категории.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Максимальную скидку.</returns>
    private double GetDiscount(BindingList<Item> items)
    {
        return GetCost(items) * CurrentDiscount / 100;
    }

    /// <summary>
    /// Вычисление стоимости всех товаров нужной категории.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Общая стоимость.</returns>
    private double GetCost(BindingList<Item> items)
    {
        double costItems = 0;
        foreach (Item item in items)
        {
            if (item.Category == Category)
            {
                costItems += item.Cost;
            }
        }

        return costItems;
    }
}
using System.ComponentModel;

public class PointsDiscount : IDiscount
{
    /// <summary>
    /// Максимальный процент скидки.
    /// </summary>
    private const double DiscountProcent = 0.3;
    /// <summary>
    /// Количество процентов накопления баллов.
    /// </summary>
    private const double AddProcent = 0.1;

    private int _countPoint;

    /// <summary>
    /// Количество баллов.
    /// </summary>
    public int CountPoints
    {
        get
        {
            return _countPoint;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Количество баллов должно быть положительным!");
            }

            _countPoint = value;
        }
    }

    /// <summary>
    /// Возвращает название скидки.
    /// </summary>
    public string Info
    {
        get
        {
            return $"Накопительная - {CountPoints} баллов";
        }
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
    /// Применяет скидку к товарам и списывает накопленные баллы.
    /// Вызывается если скидка применяется к будущему заказу.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Размер скидки.</returns>
    public double Apply(BindingList<Item> items)
    {
        double discount = GetDiscount(items);
        CountPoints -= (int)discount;

        return discount;
    }

    /// <summary>
    /// Добавляет баллы.
    /// Вызывается после каждой покупки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    public void Update(BindingList<Item> items)
    {
        _countPoint += (int)Math.Ceiling(GetCost(items) * AddProcent);
    }

    /// <summary>
    /// Вычисление максимальной скидки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Максимальную скидку.</returns>
    private double GetDiscount(BindingList<Item> items)
    {
        double maxDiscount = Math.Floor(GetCost(items) * DiscountProcent);
        return Math.Min(CountPoints, maxDiscount);
    }

    /// <summary>
    /// Вычисление стоимости всех товаров.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Общая стоимость.</returns>
    private double GetCost(BindingList<Item> items)
    {
        double costItems = 0;
        foreach (Item item in items)
        {
            costItems += item.Cost;
        }

        return costItems;
    }
}
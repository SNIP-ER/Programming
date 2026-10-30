using System.ComponentModel;

/// <summary>
/// Приоритетный заказ с выбором времени доставки.
/// </summary>
public class PriorityOrder : Order
{
    /// <summary>
    /// Желаемая дата доставки.
    /// </summary>
    public DateTime DateDelivery { get; set; }
    /// <summary>
    /// Желаемое время доставки.
    /// </summary>
    public TimesDelivery TimeDelivery { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <param name="address">Адрес доставки.</param>
    /// <param name="dateDelivery">Желаемая дата доставки.</param>
    /// <param name="timeDelivery">Желаемое время доставки.</param>
    public PriorityOrder(BindingList<Item> items, Address address,
        DateTime dateDelivery, TimesDelivery timeDelivery) : base(items, address)
    {
        DateDelivery = dateDelivery;
        TimeDelivery = timeDelivery;
    }

    /// <summary>
    /// Создаёт пустой экземпляр класса <see cref="PriorityOrder"/>.
    /// </summary>
    public PriorityOrder()
    {

    }
}
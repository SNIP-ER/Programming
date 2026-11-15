using System.ComponentModel;

/// <summary>
/// Описывает скидку, которую можно применить к списку товаров.
/// </summary>
public interface IDiscount
{
    /// <summary>
    /// Название скидки для отображения пользователю.
    /// </summary>
    string Info { get; }

    /// <summary>
    /// Возвращает размер скидки для списка товаров, не изменяя состояние скидки.
    /// Вызывается перед оформлением заказа для оценки возможной скидки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Размер скидки.</returns>
    double Calculate(BindingList<Item> items);

    /// <summary>
    /// Применяет скидку к списку товаров и возвращает её размер.
    /// Вызывается, если скидка применяется к создаваемому заказу.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    /// <returns>Размер скидки.</returns>
    double Apply(BindingList<Item> items);

    /// <summary>
    /// Обновляет данные скидки по списку товаров.
    /// Вызывается после каждой покупки.
    /// </summary>
    /// <param name="items">Список товаров.</param>
    void Update(BindingList<Item> items);
}
using System.ComponentModel;

public class PriorityOrder : Order
{
    public DateTime DataDelivery { get; set; }
    public string TimeDelivery { get; set; }

    public PriorityOrder(BindingList<Item> items, Address address) : base(items, address)
    {
        _count++;
        Id = _count;
        Date = DateTime.Now;
        Status = OrderStatus.New;
        Address = address;
        Items = items;
        TimeDelivery = TimesDelivery.EarlyMorning.GetDescription();
    }
}
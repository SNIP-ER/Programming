using System.ComponentModel;

/// <summary>
/// Желательное время доставки.
/// </summary>
public enum TimesDelivery
{
    [Description("9:00-11:00")]
    EarlyMorning,
    [Description("11:00-13:00")]
    Morning,
    [Description("13:00-15:00")]
    Lunch,
    [Description("15:00-17:00")]
    LateLanch,
    [Description("17:00-19:00")]
    EarlyEvening,
    [Description("19:00-21:00")]
    Evening
}
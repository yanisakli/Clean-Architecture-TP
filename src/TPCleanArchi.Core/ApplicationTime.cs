using System;

public class ApplicationTime
{
    public static Func<DateTime> SetNow{get; set;} = () => DateTime.Now;
    public static DateTime Now => SetNow();
}
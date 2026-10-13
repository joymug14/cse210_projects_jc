using System;
using System.Data.Common;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyy", CultureInfo.InvariantCulture)}" +
        $" {GetType().Name}({GetMinutes()} min):"+
        $" Distance {GetDistance():0.0} km," +
        $" Speed {GetSpeed() : 0.0} kph," +
        $" Pace {GetPace() : 0.00} min per km";
    }
}
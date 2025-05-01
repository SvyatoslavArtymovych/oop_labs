using System;

public class MyDate
{
    private int day;
    private int month;
    private int year;

    public static readonly int MinYear = 1;
    public static readonly int MaxYear = 9999;

    public MyDate() : this(1, 1, 2000) { }

    public MyDate(int day, int month, int year)
    {
        SetDate(day, month, year);
    }

    public int Day
    {
        get => day;
        set
        {
            if (!IsValidDate(value, month, year))
                throw new ArgumentException("Invalid day value");
            day = value;
        }
    }

    public int Month
    {
        get => month;
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentException("Month must be in the range 1–12");
            if (!IsValidDate(day, value, year))
                throw new ArgumentException("Invalid month value for this date");
            month = value;
        }
    }

    public int Year
    {
        get => year;
        set
        {
            if (value < MinYear || value > MaxYear)
                throw new ArgumentException($"Year must be in the range {MinYear}–{MaxYear}.");
            if (!IsValidDate(day, month, value))
                throw new ArgumentException("Invalid year value for this date");
            year = value;
        }
    }

    public void SetDate(int day, int month, int year)
    {
        if (!IsValidDate(day, month, year))
            throw new ArgumentException("Invalid date");
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public void Add(int addDays, int addMonths, int addYears)
    {
        DateTime temp;
        try
        {
            temp = new DateTime(year, month, day);
            temp = temp.AddYears(addYears).AddMonths(addMonths).AddDays(addDays);
        }
        catch
        {
            throw new ArgumentException("The result of the date modification is invalid");
        }

        day = temp.Day;
        month = temp.Month;
        year = temp.Year;
    }

    private bool IsValidDate(int d, int m, int y)
    {
        try
        {
            _ = new DateTime(y, m, d);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"{day:D2}.{month:D2}.{year}";
    }
}

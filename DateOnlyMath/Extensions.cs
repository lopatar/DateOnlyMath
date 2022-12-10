namespace DateOnlyMath;

public static class Extensions
{
    public static void Add(ref this DateOnly date, DateOnly dateToAdd)
    {
        date = date.AddDays(dateToAdd.DayNumber);
    }

    public static void Subtract(ref this DateOnly date, DateOnly dateToSubtract)
    {
        date = new DateOnly().AddDays(date.DayNumber - dateToSubtract.DayNumber);
    }

    public static void Multiply(ref this DateOnly date, DateOnly dateToMultiply)
    {
        date = new DateOnly().AddDays(date.DayNumber * dateToMultiply.DayNumber);
    }

    public static void Divide(ref this DateOnly date, DateOnly dateToDividedBy) 
    {
        date = new DateOnly().AddDays(date.DayNumber / dateToDividedBy.DayNumber);
    }

    public static bool BiggerThan(this DateOnly date, DateOnly dateToCompare)
    {
        return date.CompareTo(dateToCompare) > 0;
    }

    public static bool LowerThan(this DateOnly date, DateOnly dateToCompare)
    {
        return date.CompareTo(dateToCompare) < 0;
    }
}
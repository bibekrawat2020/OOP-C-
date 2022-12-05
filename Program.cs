TimePeriod.THours();
class TimePeriod
{
    private double _seconds;
    public double Hours
    {
        get { return _seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException("value", "Hours must be between 0 and 24.");
            _seconds = value * 3600;
        }
    }
    public static void THours()
    {
        TimePeriod time = new TimePeriod();
        time.Hours = 24;
        Console.WriteLine(time.Hours);
    }
}
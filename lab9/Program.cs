class Program
{
    static void Main()
    {
        try
        {
            MyDate date = new MyDate(28, 2, 2024);
            Console.WriteLine("Initial date: " + date);

            date.Add(3, 0, 0);
            Console.WriteLine("After adding 3 days: " + date);

            date.Month = 12;
            Console.WriteLine("After changing the month: " + date);

            date.Year = 2030;
            Console.WriteLine("After changing the year: " + date);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

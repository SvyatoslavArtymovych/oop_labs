
class Program
{
    static void Main()
    {
        int[,] data = {
            {1, 2, 3},
            {4, 0, 6},
            {7, 8, 9},
            {1, 2, 3}
        };

        MatrixAnalyzer analyzer = new MatrixAnalyzer(data);

        int rowsWithoutZeros = analyzer.CountRowsWithoutZeros();
        Console.WriteLine("Number of rows without zeros: " + rowsWithoutZeros);

        int? maxDuplicate = analyzer.MaxDuplicateNumber();
        if (maxDuplicate.HasValue)
            Console.WriteLine("The maximum number that repeats more than once: " + maxDuplicate);
        else
            Console.WriteLine("No number repeats more than once.");
    }
}
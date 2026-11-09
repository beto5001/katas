namespace Katas.BirthdayCakeCandles;

public static class BirthdayCakeCandlesProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.WriteLine("Enter the number of candles:");
        if (!int.TryParse(Console.ReadLine(), out int candlesCount) || candlesCount <= 0)
        {
            Console.WriteLine("Enter a positive number of candles.");
            return;
        }

        Console.WriteLine("Enter the heights of the candles separated by spaces:");
        string[] values = (Console.ReadLine() ?? "")
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (values.Length != candlesCount)
        {
            Console.WriteLine($"Enter exactly {candlesCount} candle heights.");
            return;
        }

        var candles = new List<int>(candlesCount);

        foreach (string value in values)
        {
            if (!int.TryParse(value, out int height) || height <= 0)
            {
                Console.WriteLine("Enter only positive whole numbers for the heights.");
                return;
            }

            candles.Add(height);
        }

        Console.WriteLine($"The number of tallest candles is {BirthdayCakeCandles(candles)}.");
    }

    private static int BirthdayCakeCandles(List<int> candles)
    {
        int tallestHeight = candles.Max();
        return candles.Count(height => height == tallestHeight);
    }
}
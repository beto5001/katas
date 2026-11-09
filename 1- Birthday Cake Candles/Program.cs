
Console.WriteLine("Enter the number of candles:");
int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
Console.WriteLine("Enter the heights of the candles separated by spaces:");
List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

int result = BirthdayCakeCandles(candles);

Console.WriteLine("The number of tallest candles is:");
Console.WriteLine(result);

/*
* Complete the 'birthdayCakeCandles' function below.
*
* The function is expected to return an INTEGER.
* The function accepts INTEGER_ARRAY candles as parameter.
*/
static int BirthdayCakeCandles(List<int> candles)
{
    int tallestHeight = candles.Max();
    return candles.Count(c => c == tallestHeight);
}

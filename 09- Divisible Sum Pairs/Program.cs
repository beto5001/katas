using System.Runtime.Serialization;

namespace Katas.DivisibleSumPairs;

public static class DivisibleSumPairsProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Informe a quantidade de elementos e o divisor (ex.: 6 3): ");

        if (!TryReadTwoPositiveIntegers(out int count, out int divisor))
        {
            Console.WriteLine("Informe dois números inteiros positivos separados por espaço.");
            return;
        }

        Console.Write($"Informe os {count} números inteiros separados por espaço: ");

        if (!TryReadIntegers(count, out List<int> numbers))
        {
            Console.WriteLine("Informe a quantidade correta de números inteiros separados por espaço.");
            return;
        }

        // TODO: chame DivisibleSumPairs(numbers, divisor) após implementar a solução.
    }

    /// <summary>
    /// Retorna quantos pares de índices <c>(i, j)</c>, com <c>i &lt; j</c>, possuem
    /// soma dos elementos divisível por <paramref name="divisor"/>.
    /// </summary>
    public static int DivisibleSumPairs(List<int> numbers, int divisor)
    {
        int count = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                int somaDoPar = numbers[i] + numbers[j];

                if (somaDoPar % divisor == 0)
                    count++;
            }
        }

        return count;
    }

    private static bool TryReadTwoPositiveIntegers(out int first, out int second)
    {
        first = 0;
        second = 0;

        string[] values = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];

        return values.Length == 2
            && int.TryParse(values[0], out first)
            && int.TryParse(values[1], out second)
            && first > 0
            && second > 0;
    }

    private static bool TryReadIntegers(int expectedCount, out List<int> numbers)
    {
        string[] values = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
        numbers = [];

        if (values.Length != expectedCount)
        {
            return false;
        }

        foreach (string value in values)
        {
            if (!int.TryParse(value, out int number))
            {
                return false;
            }

            numbers.Add(number);
        }

        return true;
    }
}

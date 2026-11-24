namespace Katas.SubarrayDivision;

public static class SubarrayDivisionProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Informe os quadrados de chocolate separados por espaço: ");

        if (!TryReadIntegers(out List<int> squares))
        {
            Console.WriteLine("Informe ao menos um número inteiro separado por espaço.");
            return;
        }

        Console.Write("Informe o dia e o mês de nascimento (ex.: 4 2): ");

        if (!TryReadTwoPositiveIntegers(out int day, out int month))
        {
            Console.WriteLine("Informe dois números inteiros positivos separados por espaço.");
            return;
        }

        Console.WriteLine("Implemente Birthday para resolver o desafio.");
    }

    /// <summary>
    /// Retorna a quantidade de segmentos contíguos de <paramref name="squares"/> com
    /// <paramref name="month"/> elementos cuja soma é igual a <paramref name="day"/>.
    /// </summary>
    public static int Birthday(List<int> squares, int day, int month) =>
        throw new NotImplementedException("Implemente a solução do kata.");

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

    private static bool TryReadIntegers(out List<int> numbers)
    {
        string[] values = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
        numbers = [];

        foreach (string value in values)
        {
            if (!int.TryParse(value, out int number))
            {
                return false;
            }

            numbers.Add(number);
        }

        return numbers.Count > 0;
    }
}

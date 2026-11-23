namespace Katas.BetweenTwoSets;

public static class BetweenTwoSetsProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Informe as quantidades de elementos de a e b (ex.: 2 3): ");

        if (!TryReadTwoPositiveIntegers(out int quantidadeA, out int quantidadeB))
        {
            Console.WriteLine("Informe duas quantidades inteiras positivas separadas por espaço.");
            return;
        }

        Console.Write($"Informe os {quantidadeA} elementos de a (ex.: 2 4): ");
        if (!TryReadIntegers(quantidadeA, out List<int> a))
        {
            Console.WriteLine("Informe a quantidade correta de números inteiros separados por espaço.");
            return;
        }

        Console.Write($"Informe os {quantidadeB} elementos de b (ex.: 16 32 96): ");
        if (!TryReadIntegers(quantidadeB, out List<int> b))
        {
            Console.WriteLine("Informe a quantidade correta de números inteiros separados por espaço.");
            return;
        }

        int totalDeNumerosMagicos = GetTotalX(a, b);
        Console.WriteLine($"Quantidade de números mágicos: {totalDeNumerosMagicos}");
    }

    /// <summary>
    /// Retorna a quantidade de inteiros que são múltiplos de todos os elementos de <paramref name="a"/>
    /// e divisores de todos os elementos de <paramref name="b"/>.
    /// </summary>
    public static int GetTotalX(List<int> a, List<int> b)
    {
        int magicNumber = 0;

        for (int candidato = 1; candidato <= b.Min(); candidato++)
        {
            bool divididoPorTodosDoA = a.All(numeroDeA => candidato % numeroDeA == 0);
            bool divideTodosDoB = b.All(numeroDeB => numeroDeB % candidato == 0);

            if (divididoPorTodosDoA && divideTodosDoB)
            {
                magicNumber++;
            }
        }

        return magicNumber;
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

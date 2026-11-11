namespace Katas.AppleAndOrange;

public static class AppleAndOrangeProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Início e fim da casa (ex.: 7 11): ");
        if (!TryReadPair(out int houseStart, out int houseEnd) || houseStart > houseEnd)
        {
            Console.WriteLine("Informe um intervalo válido para a casa.");
            return;
        }

        Console.Write("Posições da macieira e da laranjeira (ex.: 5 15): ");
        if (!TryReadPair(out int appleTreePosition, out int orangeTreePosition))
        {
            Console.WriteLine("Informe posições válidas para as árvores.");
            return;
        }

        Console.Write("Distâncias das maçãs (ex.: -2 2 1): ");
        if (!TryReadIntegers(out List<int> apples))
        {
            Console.WriteLine("Informe as distâncias das maçãs como números inteiros.");
            return;
        }

        Console.Write("Distâncias das laranjas (ex.: 5 -6): ");
        if (!TryReadIntegers(out List<int> oranges))
        {
            Console.WriteLine("Informe as distâncias das laranjas como números inteiros.");
            return;
        }

        (int applesOnHouse, int orangesOnHouse) = CountApplesAndOranges(
            houseStart,
            houseEnd,
            appleTreePosition,
            orangeTreePosition,
            apples,
            oranges);

        Console.WriteLine($"Maçãs que caíram na casa: {applesOnHouse}");
        Console.WriteLine($"Laranjas que caíram na casa: {orangesOnHouse}");
    }

    public static (int ApplesOnHouse, int OrangesOnHouse) CountApplesAndOranges(
        int houseStart,
        int houseEnd,
        int appleTreePosition,
        int orangeTreePosition,
        IEnumerable<int> apples,
        IEnumerable<int> oranges) =>
        (CountFruitOnHouse(houseStart, houseEnd, appleTreePosition, apples),
         CountFruitOnHouse(houseStart, houseEnd, orangeTreePosition, oranges));

    private static int CountFruitOnHouse(
        int houseStart,
        int houseEnd,
        int treePosition,
        IEnumerable<int> distances) =>
        distances.Count(distance =>
        {
            int landingPosition = treePosition + distance;
            return landingPosition >= houseStart && landingPosition <= houseEnd;
        });

    private static bool TryReadPair(out int first, out int second)
    {
        first = 0;
        second = 0;

        string? input = Console.ReadLine();
        string[] values = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];

        return values.Length == 2
            && int.TryParse(values[0], out first)
            && int.TryParse(values[1], out second);
    }

    private static bool TryReadIntegers(out List<int> values)
    {
        values = [];
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        foreach (string value in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (!int.TryParse(value, out int number))
            {
                return false;
            }

            values.Add(number);
        }

        return true;
    }
}

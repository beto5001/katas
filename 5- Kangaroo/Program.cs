namespace Katas.Kangaroo;

public static class KangarooProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Posições e saltos (x1 v1 x2 v2, ex.: 0 3 4 2): ");

        if (!TryReadInput(out int x1, out int v1, out int x2, out int v2))
        {
            Console.WriteLine("Informe quatro números inteiros separados por espaço.");
            return;
        }

        Console.WriteLine(Kangaroo(x1, v1, x2, v2));
    }

    public static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        throw new NotImplementedException("Implemente a lógica do kata Kangaroo.");
    }

    private static bool TryReadInput(out int x1, out int v1, out int x2, out int v2)
    {
        x1 = 0;
        v1 = 0;
        x2 = 0;
        v2 = 0;

        string? input = Console.ReadLine();
        string[] values = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];

        return values.Length == 4
            && int.TryParse(values[0], out x1)
            && int.TryParse(values[1], out v1)
            && int.TryParse(values[2], out x2)
            && int.TryParse(values[3], out v2);
    }
}

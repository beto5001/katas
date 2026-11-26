namespace Katas.MigratoryBirds;

public static class MigratoryBirdsProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Informe a quantidade de aves observadas: ");

        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Informe uma quantidade inteira positiva.");
            return;
        }

        Console.Write($"Informe os {count} tipos de aves separados por espaço: ");
        string[] values = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
        List<int> birds = [];

        if (values.Length != count)
        {
            Console.WriteLine("Informe a quantidade correta de tipos de aves.");
            return;
        }

        foreach (string value in values)
        {
            if (!int.TryParse(value, out int bird) || bird < 1 || bird > 5)
            {
                Console.WriteLine("Informe tipos de aves inteiros entre 1 e 5.");
                return;
            }

            birds.Add(bird);
        }

        // TODO: chame MigratoryBirds(birds) após implementar a solução.
    }

    /// <summary>
    /// Retorna o tipo de ave mais observado; em caso de empate, retorna o menor tipo.
    /// </summary>
    public static int MigratoryBirds(List<int> birds)
    {
        throw new NotImplementedException();
    }
}

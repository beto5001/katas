namespace Katas.Kangaroo;

public static class KangarooProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Posições e saltos (x1 v1 x2 v2, ex.: 0 3 4 2): ");

        if (!TryReadInput(
                out int posicaoInicialCanguru1,
                out int distanciaDoPuloCanguru1,
                out int posicaoInicialCanguru2,
                out int distanciaDoPuloCanguru2))
        {
            Console.WriteLine("Informe quatro números inteiros separados por espaço.");
            return;
        }

        Console.WriteLine(Kangaroo(
            posicaoInicialCanguru1,
            distanciaDoPuloCanguru1,
            posicaoInicialCanguru2,
            distanciaDoPuloCanguru2));
    }

    public static string Kangaroo(
        int posicaoInicialCanguru1,
        int distanciaDoPuloCanguru1,
        int posicaoInicialCanguru2,
        int distanciaDoPuloCanguru2)
    {
        int posicaoAtualCanguru1 = posicaoInicialCanguru1;
        int posicaoAtualCanguru2 = posicaoInicialCanguru2;
        int distanciaAnterior = Math.Abs(posicaoAtualCanguru1 - posicaoAtualCanguru2);

        if (distanciaAnterior == 0)
        {
            return "YES";
        }

        while (true)
        {
            posicaoAtualCanguru1 += distanciaDoPuloCanguru1;
            posicaoAtualCanguru2 += distanciaDoPuloCanguru2;

            int distanciaAtual = Math.Abs(posicaoAtualCanguru1 - posicaoAtualCanguru2);

            if (distanciaAtual == 0)
            {
                return "YES";
            }

            if (distanciaAtual >= distanciaAnterior)
            {
                return "NO";
            }

            distanciaAnterior = distanciaAtual;
        }
    }

    private static bool TryReadInput(
        out int posicaoInicialCanguru1,
        out int distanciaDoPuloCanguru1,
        out int posicaoInicialCanguru2,
        out int distanciaDoPuloCanguru2)
    {
        posicaoInicialCanguru1 = 0;
        distanciaDoPuloCanguru1 = 0;
        posicaoInicialCanguru2 = 0;
        distanciaDoPuloCanguru2 = 0;

        string? input = Console.ReadLine();
        string[] valoresInformados = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];

        return valoresInformados.Length == 4
            && int.TryParse(valoresInformados[0], out posicaoInicialCanguru1)
            && int.TryParse(valoresInformados[1], out distanciaDoPuloCanguru1)
            && int.TryParse(valoresInformados[2], out posicaoInicialCanguru2)
            && int.TryParse(valoresInformados[3], out distanciaDoPuloCanguru2);
    }
}

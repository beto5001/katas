namespace Katas.BreakingTheRecords;

public static class BreakingTheRecordsProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Informe a quantidade de jogos: ");

        if (!int.TryParse(Console.ReadLine(), out int quantidadeDeJogos) || quantidadeDeJogos <= 0)
        {
            Console.WriteLine("Informe uma quantidade inteira positiva de jogos.");
            return;
        }

        Console.Write($"Informe as {quantidadeDeJogos} pontuações separadas por espaço: ");

        if (!TryReadScores(quantidadeDeJogos, out List<int> scores))
        {
            Console.WriteLine("Informe a quantidade correta de números inteiros separados por espaço.");
            return;
        }

        int[] recordsBroken = BreakingRecords(scores);
        Console.WriteLine($"{recordsBroken[0]} {recordsBroken[1]}");
    }

    /// <summary>
    /// Retorna um array com dois itens: a quantidade de vezes que o recorde máximo
    /// e o recorde mínimo foram quebrados, nessa ordem.
    /// </summary>
    public static int[] BreakingRecords(List<int> scores)
    {
        int lowScoreBreaking = 0;
        int lowScoreCurrent = scores.FirstOrDefault();
        int highScoreBreaking = 0;
        int highScoreCurrent = scores.FirstOrDefault();

        foreach (int score in scores)
        {
            if (score > highScoreCurrent)
            {
                highScoreCurrent = score;
                highScoreBreaking++;
            }
            if (score < lowScoreCurrent)
            {
                lowScoreCurrent = score;
                lowScoreBreaking++;
            }
        }

        return [highScoreBreaking, lowScoreBreaking];
    }

    private static bool TryReadScores(int expectedCount, out List<int> scores)
    {
        string[] values = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
        scores = [];

        if (values.Length != expectedCount)
        {
            return false;
        }

        foreach (string value in values)
        {
            if (!int.TryParse(value, out int score))
            {
                return false;
            }

            scores.Add(score);
        }

        return true;
    }
}

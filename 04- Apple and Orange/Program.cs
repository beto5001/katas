namespace Katas.AppleAndOrange;

public static class AppleAndOrangeProgram
{
    public static void Main() => Run();

    public static void Run()
    {
        Console.Write("Informe o início (s) e o fim (t) da casa, separados por espaço (ex.: 7 11): ");
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);

        Console.Write("Informe as posições da macieira (a) e da laranjeira (b), separadas por espaço (ex.: 5 15): ");
        string[] secondMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);
        int b = Convert.ToInt32(secondMultipleInput[1]);

        Console.Write("Informe as quantidades de maçãs (m) e laranjas (n), separadas por espaço (ex.: 3 2): ");
        string[] thirdMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);
        int n = Convert.ToInt32(thirdMultipleInput[1]);

        Console.Write("Informe as distâncias das maçãs, separadas por espaço (ex.: -2 2 1): ");
        List<int> apples = Console.ReadLine()!.TrimEnd().Split(' ').ToList()
            .Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        Console.Write("Informe as distâncias das laranjas, separadas por espaço (ex.: 5 -6): ");
        List<int> oranges = Console.ReadLine()!.TrimEnd().Split(' ').ToList()
            .Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.CountApplesAndOranges(s, t, a, b, apples, oranges);
    }
}

public static class Result
{
    public static void CountApplesAndOranges(int limiteInicialDaCasa,
                                             int limiteFinalDaCasa,
                                             int localizacaoDaMacieira,
                                             int localizacaoDaLaranjeira,
                                             List<int> apples,
                                             List<int> oranges)
    {
        int macasNoPerimetroDaCasa = apples.Sum(localizacaoFruta => EstaNoTerrenoDaCasa(limiteInicialDaCasa,
                                                                                        limiteFinalDaCasa,
                                                                                        localizacaoDaMacieira,
                                                                                        localizacaoFruta));

        int laranjasNoPerimetroDaCasa = oranges.Sum(localizacaoFruta => EstaNoTerrenoDaCasa(limiteInicialDaCasa,
                                                                                            limiteFinalDaCasa,
                                                                                            localizacaoDaLaranjeira,
                                                                                            localizacaoFruta));


        Console.WriteLine(macasNoPerimetroDaCasa);
        Console.WriteLine(laranjasNoPerimetroDaCasa);
    }

    private static int EstaNoTerrenoDaCasa(int limiteInicialDaCasa, int limiteFinalDaCasa, int localizacaoArvore, int localizacaoFruta)
    {
        int localizacaoRelativaFruta = localizacaoArvore + localizacaoFruta;

        if (localizacaoRelativaFruta.IsBetween(limiteInicialDaCasa, limiteFinalDaCasa))
            return 1;

        return 0;
    }

    private static bool IsBetween(this int referencia, int inicial, int final) =>
        referencia >= inicial && referencia <= final;
}

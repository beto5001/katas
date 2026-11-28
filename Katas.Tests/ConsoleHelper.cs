namespace Katas.Tests;

internal static class ConsoleHelper
{
    public static string Executar(string entrada, Action executar)
    {
        TextReader entradaOriginal = Console.In;
        TextWriter saidaOriginal = Console.Out;
        using StringReader leitor = new(entrada);
        using StringWriter escritor = new();

        try
        {
            Console.SetIn(leitor);
            Console.SetOut(escritor);
            executar();
            return escritor.ToString();
        }
        finally
        {
            Console.SetIn(entradaOriginal);
            Console.SetOut(saidaOriginal);
        }
    }
}

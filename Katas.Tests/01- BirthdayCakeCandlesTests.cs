using Katas.BirthdayCakeCandles;

namespace Katas.Tests;

public class BirthdayCakeCandlesTests
{
    [Fact]
    public void Velas_conta_as_mais_altas_pelo_console()
    {
        string output = ConsoleHelper.Executar("4\n3 2 1 3\n", BirthdayCakeCandlesProgram.Run);
        Assert.Contains("The number of tallest candles is 2.", output);
    }

    [Fact]
    public void Velas_rejeita_quantidade_incorreta()
    {
        string output = ConsoleHelper.Executar("3\n1 2\n", BirthdayCakeCandlesProgram.Run);
        Assert.Contains("Enter exactly 3 candle heights.", output);
    }
    [Theory]
    [InlineData("1\n7\n", "is 1.")]
    [InlineData("4\n5 5 5 5\n", "is 4.")]
    [InlineData("4\n9 1 2 3\n", "is 1.")]
    [InlineData("4\n1 2 3 9\n", "is 1.")]
    [InlineData("0\n", "Enter a positive number of candles.")]
    [InlineData("-1\n", "Enter a positive number of candles.")]
    [InlineData("abc\n", "Enter a positive number of candles.")]
    [InlineData("2\n1 0\n", "Enter only positive whole numbers")]
    [InlineData("2\n1 abc\n", "Enter only positive whole numbers")]
    public void Velas_processa_casos_de_entrada(string entrada, string esperado) =>
        Assert.Contains(esperado, ConsoleHelper.Executar(entrada, BirthdayCakeCandlesProgram.Run));
}

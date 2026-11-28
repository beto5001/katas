using Katas.AppleAndOrange;

namespace Katas.Tests;

public class AppleAndOrangeTests
{
    [Fact]
    public void Frutas_conta_as_que_caem_nos_limites_da_casa()
    {
        string output = ConsoleHelper.Executar("", () => Result.CountApplesAndOranges(
            7, 11, 5, 15, [1, 2, 6, 7], [-9, -8, -4, -3]));
        Assert.Equal($"2{Environment.NewLine}2{Environment.NewLine}", output);
    }
    [Theory]
    [InlineData(new int[] { }, new int[] { }, 0, 0)]
    [InlineData(new[] { 2 }, new int[] { }, 1, 0)]
    [InlineData(new[] { 6 }, new int[] { }, 1, 0)]
    [InlineData(new[] { 1 }, new[] { -3 }, 0, 0)]
    [InlineData(new[] { 7 }, new[] { -9 }, 0, 0)]
    [InlineData(new int[] { }, new[] { -8 }, 0, 1)]
    [InlineData(new int[] { }, new[] { -4 }, 0, 1)]
    [InlineData(new[] { 2, 2, 3 }, new[] { -8, -4 }, 3, 2)]
    [InlineData(new[] { -2, 2, 1 }, new[] { 5, -6 }, 1, 1)]
    public void Frutas_conta_por_posicao_e_tipo(int[] macas, int[] laranjas, int esperadasMacas, int esperadasLaranjas)
    {
        string output = ConsoleHelper.Executar("", () => Result.CountApplesAndOranges(7, 11, 5, 15, [.. macas], [.. laranjas]));
        Assert.Equal($"{esperadasMacas}{Environment.NewLine}{esperadasLaranjas}{Environment.NewLine}", output);
    }
}

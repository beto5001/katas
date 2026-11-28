using Katas.DivisibleSumPairs;

namespace Katas.Tests;

public class DivisibleSumPairsTests
{
    [Fact]
    public void Pares_conta_indices_cuja_soma_e_divisivel() =>
        Assert.Equal(5, DivisibleSumPairsProgram.DivisibleSumPairs([1, 3, 2, 6, 1, 2], 3));

    [Fact]
    public void Pares_considera_valores_repetidos_em_indices_distintos() =>
        Assert.Equal(3, DivisibleSumPairsProgram.DivisibleSumPairs([1, 1, 1], 2));
    [Theory]
    [InlineData(new[] { 1, 2 }, 3, 1)]
    [InlineData(new[] { 1, 2 }, 2, 0)]
    [InlineData(new[] { 1, 2, 3, 4 }, 1, 6)]
    [InlineData(new[] { 2, 4, 6 }, 2, 3)]
    [InlineData(new[] { 1, 3, 5 }, 2, 3)]
    [InlineData(new[] { 1, 2, 4 }, 3, 2)]
    [InlineData(new[] { 3, 6, 9 }, 3, 3)]
    [InlineData(new[] { 1, 1, 2, 2 }, 3, 4)]
    public void Pares_avalia_resto_repeticao_e_limites(int[] numeros, int divisor, int esperado) =>
        Assert.Equal(esperado, DivisibleSumPairsProgram.DivisibleSumPairs([.. numeros], divisor));
}

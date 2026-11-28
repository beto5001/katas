using Katas.BetweenTwoSets;

namespace Katas.Tests;

public class BetweenTwoSetsTests
{
    [Fact]
    public void Conjuntos_conta_multiplos_e_divisores_comuns() =>
        Assert.Equal(3, BetweenTwoSetsProgram.GetTotalX([2, 4], [16, 32, 96]));

    [Fact]
    public void Conjuntos_retorna_zero_quando_nao_ha_candidato() =>
        Assert.Equal(0, BetweenTwoSetsProgram.GetTotalX([3], [5]));
    [Theory]
    [InlineData(new[] { 1 }, new[] { 1 }, 1)]
    [InlineData(new[] { 2 }, new[] { 2 }, 1)]
    [InlineData(new[] { 1 }, new[] { 12 }, 6)]
    [InlineData(new[] { 2 }, new[] { 8 }, 3)]
    [InlineData(new[] { 4, 6 }, new[] { 24, 36 }, 1)]
    [InlineData(new[] { 2, 3 }, new[] { 5, 7 }, 0)]
    [InlineData(new[] { 2, 2 }, new[] { 8, 8 }, 3)]
    [InlineData(new[] { 5, 10 }, new[] { 10, 20 }, 1)]
    public void Conjuntos_avalia_limites_e_elementos(int[] a, int[] b, int esperado) =>
        Assert.Equal(esperado, BetweenTwoSetsProgram.GetTotalX([.. a], [.. b]));
}

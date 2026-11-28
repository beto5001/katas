using Katas.SubarrayDivision;

namespace Katas.Tests;

public class SubarrayDivisionTests
{
    [Fact]
    public void Chocolate_conta_segmentos_contiguos_inclusive_sobrepostos() =>
        Assert.Equal(2, SubarrayDivisionProgram.Birthday([1, 2, 1, 3, 2], 3, 2));

    [Fact]
    public void Chocolate_sem_segmento_do_tamanho_pedido_retorna_zero() =>
        Assert.Equal(0, SubarrayDivisionProgram.Birthday([1, 2], 3, 3));
    [Theory]
    [InlineData(new[] { 4 }, 4, 1, 1)]
    [InlineData(new[] { 4 }, 3, 1, 0)]
    [InlineData(new[] { 1, 2, 3 }, 6, 3, 1)]
    [InlineData(new[] { 1, 2, 3 }, 5, 3, 0)]
    [InlineData(new[] { 1, 1, 1, 1 }, 2, 2, 3)]
    [InlineData(new[] { 1, 2, 3 }, 5, 2, 1)]
    [InlineData(new[] { 1, 2, 3 }, 3, 2, 1)]
    [InlineData(new[] { 2, 2, 2 }, 2, 1, 3)]
    public void Chocolate_avalia_janelas_e_limites(int[] quadrados, int dia, int mes, int esperado) =>
        Assert.Equal(esperado, SubarrayDivisionProgram.Birthday([.. quadrados], dia, mes));
}

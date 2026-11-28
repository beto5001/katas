using Katas.BreakingTheRecords;

namespace Katas.Tests;

public class BreakingTheRecordsTests
{
    [Fact]
    public void Recordes_conta_maximos_e_minimos_sem_contar_empates() =>
        Assert.Equal(new[] { 2, 4 }, BreakingTheRecordsProgram.BreakingRecords([10, 5, 20, 20, 4, 5, 2, 25, 1]));

    [Fact]
    public void Recordes_com_um_jogo_nao_sao_quebrados() =>
        Assert.Equal(new[] { 0, 0 }, BreakingTheRecordsProgram.BreakingRecords([10]));
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, 3, 0)]
    [InlineData(new[] { 4, 3, 2, 1 }, 0, 3)]
    [InlineData(new[] { 5, 5, 5 }, 0, 0)]
    [InlineData(new[] { 5, 6, 4 }, 1, 1)]
    [InlineData(new[] { 5, 4, 6 }, 1, 1)]
    [InlineData(new[] { 0, 0, 1 }, 1, 0)]
    [InlineData(new[] { 3, 4, 3, 4, 2 }, 1, 1)]
    [InlineData(new[] { 10, 9, 8, 9, 7 }, 0, 3)]
    public void Recordes_conta_apenas_novos_extremos(int[] pontos, int maximos, int minimos) =>
        Assert.Equal(new[] { maximos, minimos }, BreakingTheRecordsProgram.BreakingRecords([.. pontos]));
}

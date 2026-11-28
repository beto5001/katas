using Katas.MigratoryBirds;

namespace Katas.Tests;

public class MigratoryBirdsTests
{
    [Theory]
    [InlineData(new[] { 1, 4, 4, 4, 5, 3 }, 4)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }, 3)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 5 }, 5)]
    [InlineData(new[] { 2, 2, 2 }, 2)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 1)]
    [InlineData(new[] { 5, 5, 2, 2 }, 2)]
    [InlineData(new[] { 3, 3, 1, 2, 2 }, 2)]
    [InlineData(new[] { 5, 4, 5, 4, 5 }, 5)]
    [InlineData(new[] { 4, 1, 4, 1, 3, 3 }, 1)]
    public void Aves_retorna_tipo_mais_frequente_e_desempata_pelo_menor(int[] aves, int esperado) =>
        Assert.Equal(esperado, MigratoryBirdsProgram.MigratoryBirds([.. aves]));

    [Fact]
    public void Aves_rejeita_tipo_fora_do_intervalo()
    {
        string output = ConsoleHelper.Executar("2\n1 6\n", MigratoryBirdsProgram.Run);
        Assert.Contains("Informe tipos de aves inteiros entre 1 e 5.", output);
    }
}

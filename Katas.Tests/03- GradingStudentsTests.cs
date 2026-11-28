using Katas.GradingStudents;

namespace Katas.Tests;

public class GradingStudentsTests
{
    [Fact]
    public void Notas_arredonda_apenas_quando_as_regras_permitem() =>
        Assert.Equal(new[] { 75, 67, 40, 33, 37, 40, 100 },
            GradingStudentsProgram.GradingStudents([73, 67, 38, 33, 37, 40, 100]));
    [Theory]
    [InlineData(0, 0)]
    [InlineData(37, 37)]
    [InlineData(38, 40)]
    [InlineData(39, 40)]
    [InlineData(40, 40)]
    [InlineData(41, 41)]
    [InlineData(42, 42)]
    [InlineData(43, 45)]
    [InlineData(98, 100)]
    [InlineData(100, 100)]
    public void Notas_respeita_limites_de_arredondamento(int nota, int esperado) =>
        Assert.Equal(new[] { esperado }, GradingStudentsProgram.GradingStudents([nota]));

    [Fact]
    public void Notas_lista_vazia_retorna_lista_vazia() =>
        Assert.Empty(GradingStudentsProgram.GradingStudents([]));
}

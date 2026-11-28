using Katas.TimeConversion;

namespace Katas.Tests;

public class TimeConversionTests
{
    [Theory]
    [InlineData("12:00:00AM", "00:00:00")]
    [InlineData("12:00:00PM", "12:00:00")]
    [InlineData("07:05:45PM", "19:05:45")]
    [InlineData("07:05:45AM", "07:05:45")]
    [InlineData("12:59:59AM", "00:59:59")]
    [InlineData("12:59:59PM", "12:59:59")]
    [InlineData("01:00:00PM", "13:00:00")]
    [InlineData("11:59:59PM", "23:59:59")]
    [InlineData("11:59:59AM", "11:59:59")]
    [InlineData("01:02:03pm", "13:02:03")]
    public void Horario_converte_os_periodos(string entrada, string esperado) =>
        Assert.Equal(esperado, TimeConversionProgram.TimeConversion(entrada));

    [Fact]
    public void Horario_vazio_e_rejeitado_no_console() =>
        Assert.Contains("Informe um horário.", ConsoleHelper.Executar("\n", TimeConversionProgram.Run));
}

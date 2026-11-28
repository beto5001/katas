using Katas.Kangaroo;

namespace Katas.Tests;

public class KangarooTests
{
    [Theory]
    [InlineData(0, 3, 4, 2, "YES")]
    [InlineData(0, 2, 5, 3, "NO")]
    [InlineData(0, 3, 5, 1, "NO")]
    [InlineData(2, 2, 2, 3, "YES")]
    [InlineData(0, 2, 4, 2, "NO")]
    [InlineData(0, 5, 4, 1, "YES")]
    [InlineData(0, 4, 3, 1, "YES")]
    [InlineData(0, 4, 2, 1, "NO")]
    [InlineData(3, 1, 0, 2, "YES")]
    [InlineData(10, 1, 0, 1, "NO")]
    public void Cangurus_identifica_se_encontram(int x1, int v1, int x2, int v2, string esperado) =>
        Assert.Equal(esperado, KangarooProgram.Kangaroo(x1, v1, x2, v2));
}

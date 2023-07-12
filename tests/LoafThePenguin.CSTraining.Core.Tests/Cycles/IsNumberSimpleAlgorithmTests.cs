using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Cycles;

namespace LoafThePenguin.CSTraining.Core.Tests.Cycles;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

public sealed class IsNumberSimpleAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Определение признака простого числа";

    private readonly IsNumberSimpleAlgorithm _algorithm;

    public IsNumberSimpleAlgorithmTests() => _algorithm = new IsNumberSimpleAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData(0, true)]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    public void IsNumberSimple(int number, bool isSimple)
    {
        Assert.Equal(isSimple, _algorithm.Run(number));
    }
}

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Cycles;

namespace LoafThePenguin.CSTraining.Core.Tests.Cycles;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

public sealed class ReverseNumberAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Получение зеркального числа";

    private readonly ReverseNumberAlgorithm _algorithm;

    public ReverseNumberAlgorithmTests() => _algorithm = new ReverseNumberAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(123, 321)]
    [InlineData(10, 1)]
    [InlineData(1000, 1)]
    [InlineData(12340, 4321)]
    public void ReverseNumber(int number, int exptected)
    {
        Assert.Equal(exptected, _algorithm.Run(number));
    }
}

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

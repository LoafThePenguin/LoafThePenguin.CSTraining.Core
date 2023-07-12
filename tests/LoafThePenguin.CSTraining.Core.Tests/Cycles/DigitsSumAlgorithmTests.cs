using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Cycles;

namespace LoafThePenguin.CSTraining.Core.Tests.Cycles;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

public sealed class DigitsSumAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Сумма цифр числа";

    private readonly DigitsSumAlgorithm _algorithm;

    public DigitsSumAlgorithmTests() => _algorithm = new DigitsSumAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData(-123, 6)]
    [InlineData(0, 0)]
    [InlineData(548932, 31)]
    public void DigitsSum(int number, int excepted)
    {
        Assert.Equal(excepted, _algorithm.Run(number));
    }
}

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

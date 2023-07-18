using LoafThePenguin.CSTraining.Core.Basic.Cycles;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

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
    public void DigitsSum(int number, int expected)
    {
        Assert.Equal(expected, _algorithm.Run(number));
    }
}

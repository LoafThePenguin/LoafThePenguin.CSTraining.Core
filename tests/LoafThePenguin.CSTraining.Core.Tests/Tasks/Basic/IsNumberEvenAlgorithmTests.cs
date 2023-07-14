using LoafThePenguin.CSTraining.Core.Basic.Condition;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class IsNumberEvenAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Определение признака чётного числа";

    private readonly IsNumberEvenAlgorithm _algorithm;

    public IsNumberEvenAlgorithmTests() => _algorithm = new IsNumberEvenAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData(2, true)]
    [InlineData(17, false)]
    [InlineData(0, true)]
    [InlineData(1, false)]
    [InlineData(22, true)]
    public void IsNumberEven(int number, bool isEven)
    {
        Assert.Equal(isEven, _algorithm.Run(number));
    }
}

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

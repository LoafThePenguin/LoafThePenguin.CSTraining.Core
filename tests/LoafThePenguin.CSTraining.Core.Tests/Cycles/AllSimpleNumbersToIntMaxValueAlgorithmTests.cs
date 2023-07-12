using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Cycles;

namespace LoafThePenguin.CSTraining.Core.Tests.Cycles;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

public sealed class AllSimpleNumbersToIntMaxValueAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Получение N первых простых чисел";

    private readonly AllSimpleNumbersToIntMaxValueAlgorithm _algorithm;

    public AllSimpleNumbersToIntMaxValueAlgorithmTests() => _algorithm = new AllSimpleNumbersToIntMaxValueAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData(9, 1, 2, 3, 5, 7, 11, 13, 17, 19)]
    [InlineData(10, 1, 2, 3, 5, 7, 11, 13, 17, 19, 23)]
    [InlineData(0)]
    public void AllSimpleNumbersToIntMaxValue(int n, params int[] values)
    {
        int[] actual = _algorithm.Run(n).ToArray();

        Assert.Equal(values, actual);
    }
}

#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена

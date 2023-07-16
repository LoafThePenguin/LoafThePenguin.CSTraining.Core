using LoafThePenguin.CSTraining.Core.Basic.Cycles;
using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class ArrayDoubleItemsSumAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Сумма элементов массива";

    private readonly ArrayDoubleItemsSumAlgorithm _algorithm;

    public ArrayDoubleItemsSumAlgorithmTests() => _algorithm = new ArrayDoubleItemsSumAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData(new[] { 23, 12.23, 93, 1203.23 })]
    [InlineData(new double[] { })]
    [InlineData(new[] { -23.23 })]
    [InlineData(new[] { -23.23, 10, 15.254 })]
    public void ArrayDoubleItemsSum(double[] items)
    {
        double excepted = items.Any()
            ? items.Sum() 
            : 0;

        Assert.Equal(excepted, _algorithm.Run(items));
    }
}

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

using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class InsensitiveStringsEqualityTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Регистронезависимое сравнение";
    private const string ANE_THROWS = $"Выбрасывает {nameof(ArgumentNullException)}";

    private readonly InsensitiveStringsEqualityAlgorithm _algorithm;

    public InsensitiveStringsEqualityTests() => _algorithm = new InsensitiveStringsEqualityAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("", "")]
    [InlineData("abc", "")]
    [InlineData("", "abc")]
    [InlineData(" abC", "abc")]
    [InlineData("abC", "abc")]
    [InlineData("abC", "abc ")]
    [InlineData("QwERtY", "qWeRtY")]
    public void InsensitiveStringsEquality(string str1, string str2)
    {
        bool expected = str1.ToUpper() == str2.ToUpper();

        Assert.Equal(expected, _algorithm.Run(str1, str2));
    }

    [Theory(Timeout = TIMEOUT, DisplayName = ANE_THROWS)]
    [InlineData(null, "")]
    [InlineData("", null)]
    public void Throws_ANE(string? str1, string? str2)
    {
        Assert.Throws<ArgumentNullException>(() => _algorithm.Run(str1!, str2!));
    }
}

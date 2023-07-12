using LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Cycles;

namespace LoafThePenguin.CSTraining.Core;

internal class Program
{
    private static readonly DigitsSumAlgorithm _digitsSumAlgorithm = new();

    private static void Main()
    {
        Console.WriteLine(_digitsSumAlgorithm.Run(1235));
        Console.WriteLine(_digitsSumAlgorithm.Run(56));
        Console.WriteLine(_digitsSumAlgorithm.Run(17365));
    }
}

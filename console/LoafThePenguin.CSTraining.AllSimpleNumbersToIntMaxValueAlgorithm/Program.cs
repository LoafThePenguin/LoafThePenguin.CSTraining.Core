using LoafThePenguin.CSTraining.Core.Cycles;

AllSimpleNumbersToIntMaxValueAlgorithm algorithm = new();
IEnumerable<int> simpleNumbers = algorithm.Run(10);

foreach (int number in simpleNumbers.OrderBy(x => x))
{
    Console.WriteLine(number);
}

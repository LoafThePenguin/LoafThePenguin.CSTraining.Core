namespace LoafThePenguin.CSTraining.Core
{
    public interface IAlgorithm<TInput, TOutput>
    {
        TOutput Run(TInput input);
    }
}

namespace InterfaceRefactoringExercise.Core.Interfaces;

public interface IMemoryStreamFactory
{
    Task<Stream> GetStreamAsync();
}
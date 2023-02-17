namespace InterfaceRefactoringExercise.Core.Interfaces;

public interface ILoggerFactory
{
    ILogger CreateLogger<T>();
}
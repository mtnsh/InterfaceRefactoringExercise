namespace InterfaceRefactoringExercise.Core.Interfaces
{
    public interface ICleaningServices
    {
        Task<bool> RemoveStainsAsync();
        Task<bool> RemoveTicketsAsync();
        Task OptimizeAsync();

        //More tasks to perform here
    }
}
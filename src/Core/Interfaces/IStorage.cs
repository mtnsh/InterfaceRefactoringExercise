namespace InterfaceRefactoringExercise.Core.Interfaces
{
    public interface IStorage
    {
        Task<bool> StoreAsync<T>(IEnumerable<T> collection);
    }
}
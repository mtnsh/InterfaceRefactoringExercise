using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Infra
{
    internal class Storage : IStorage
    {
        public Storage(ILogger logger)
        {
        }
        public Task<bool> StoreAsync<T>(IEnumerable<T> collection)
        {
            throw new NotImplementedException();
        }
    }
}
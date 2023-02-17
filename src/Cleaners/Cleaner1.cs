using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Cleaners
{
    public class Cleaner1
    {
        private readonly IStorage _storage;
        private readonly IMemoryStreamFactory _memoryStreamFactory;
        private readonly ILogger _logger;

        public Cleaner1(IStorage storage, IMemoryStreamFactory memoryStreamFactory, ILogger logger)
        {
            _storage = storage;
            _memoryStreamFactory = memoryStreamFactory;
            _logger = logger;
        }
    }
}
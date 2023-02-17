using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Cleaners
{
    public class Cleaner3
    {
        private readonly IStorage _storage;
        private readonly IMemoryStreamFactory _memoryStreamFactory;
        private readonly ILogger _logger;

        public Cleaner3(IStorage storage, IMemoryStreamFactory memoryStreamFactory, ILogger logger)
        {
            _storage = storage;
            _memoryStreamFactory = memoryStreamFactory;
            _logger = logger;
        }
    }
}
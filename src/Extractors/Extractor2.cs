using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Extractors
{
    internal class Extractor2
    {
        private readonly ILogger _logger;

        public Extractor2(IStorage _storage, ILogger logger)
        {
            _logger = logger;
        }
    }
}
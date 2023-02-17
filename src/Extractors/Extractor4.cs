using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Extractors
{
    internal class Extractor4
    {
        private readonly ILogger _logger;

        public Extractor4(IStorage _storage, ILogger logger)
        {
            _logger = logger;
        }
    }
}
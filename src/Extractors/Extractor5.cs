using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Extractors
{
    internal class Extractor5
    {
        private readonly ILogger _logger;

        public Extractor5(IStorage _storage, ILogger logger)
        {
            _logger = logger;
        }
    }
}
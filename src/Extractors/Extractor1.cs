using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Extractors
{
    internal class Extractor1
    {
        private readonly ILogger _logger;

        public Extractor1(IStorage _storage, ILogger logger)
        {
            _logger = logger;
        }
    }
}
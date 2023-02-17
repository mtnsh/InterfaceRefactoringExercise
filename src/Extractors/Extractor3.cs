using InterfaceRefactoringExercise.Core.Interfaces;

namespace InterfaceRefactoringExercise.Extractors
{
    internal class Extractor3
    {
        private readonly ILogger _logger;

        public Extractor3(IStorage _storage, ILogger logger)
        {
            logger = logger;
        }
    }
}
using InterfaceRefactoringExercise.Cleaners;
using InterfaceRefactoringExercise.Core.Interfaces;
using InterfaceRefactoringExercise.Extractors;
using InterfaceRefactoringExercise.Infra;

namespace InterfaceRefactoringExercise.Services
{
    public class CleaningServices : ICleaningServices
    {
        private readonly ILogger _logger;
        private readonly ILoggerFactory _loggerFactory;
        private readonly IMemoryStreamFactory _memoryStreamFactory;

        // Storage
        private readonly IStorage _storage;

        // Cleaners.
        private Cleaner1 _cleaner1;
        private Cleaner2 _cleaner2;
        private Cleaner3 _cleaner3;
        private Cleaner4 _cleaner4;
        private Cleaner5 _cleaner5;
        private Cleaner6 _cleaner6;
        private Cleaner7 _cleaner7;

        // Extractors
        private Extractor1 _extractor1;
        private Extractor2 _extractor2;
        private Extractor3 _extractor3;
        private Extractor4 _extractor4;
        private Extractor5 _extractor5;

        public CleaningServices(IMemoryStreamFactory memoryStreamFactory, ILogger logger, ILoggerFactory loggerFactory)
        {
            _logger = logger;
            _loggerFactory = loggerFactory;
            _memoryStreamFactory = memoryStreamFactory;

            _storage = new Storage(_loggerFactory.CreateLogger<Storage>());

            InitCleaners();
            InitExtractors();
        }

        private void InitExtractors()
        {
            _extractor1 = new Extractor1(_storage, _loggerFactory.CreateLogger<Extractor1>());
            _extractor2 = new Extractor2(_storage, _loggerFactory.CreateLogger<Extractor2>());
            _extractor3 = new Extractor3(_storage, _loggerFactory.CreateLogger<Extractor3>());
            _extractor4 = new Extractor4(_storage, _loggerFactory.CreateLogger<Extractor4>());
            _extractor5 = new Extractor5(_storage, _loggerFactory.CreateLogger<Extractor5>());
        }

        private void InitCleaners()
        {
            _cleaner1 = new Cleaner1(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner1>());
            _cleaner2 = new Cleaner2(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner2>());
            _cleaner3 = new Cleaner3(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner3>());
            _cleaner4 = new Cleaner4(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner4>());
            _cleaner5 = new Cleaner5(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner5>());
            _cleaner6 = new Cleaner6(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner6>());
            _cleaner7 = new Cleaner7(_storage, _memoryStreamFactory, _loggerFactory.CreateLogger<Cleaner7>());
        }

       

        public async Task<bool> RemoveTicketsAsync()
        {
            //Remove tickets
            return true;
        }

        public Task<bool> RemoveStainsAsync()
        {
            throw new NotImplementedException();
        }

        public Task OptimizeAsync()
        {
            throw new NotImplementedException();
        }

        //More tasks to perform here
    }
}
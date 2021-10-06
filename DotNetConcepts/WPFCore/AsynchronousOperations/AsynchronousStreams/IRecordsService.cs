using System.Collections.Generic;

namespace WPFCore.AsynchronousOperations.AsynchronousStreams
{
    public interface IRecordsService
    {
        public IAsyncEnumerable<Record> GetRecordsFromFile();
    }
}
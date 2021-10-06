using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCore.AsynchronousOperations.AsynchronousStreams
{
    public class RecordsService : IRecordsService
    {
        public async IAsyncEnumerable<Record> GetRecordsFromFile()
        {
            StreamReader reader = new StreamReader(File.OpenRead("DataFiles/Records.csv"));
            _ = await reader.ReadLineAsync();

            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                await Task.Delay(100);
                yield return Record.GetFromCSV(line);
            }
        }
    }
}

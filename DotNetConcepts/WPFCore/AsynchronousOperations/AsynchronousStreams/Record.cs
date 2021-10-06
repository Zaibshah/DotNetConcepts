using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCore.AsynchronousOperations.AsynchronousStreams
{
    public class Record
    {
        public string PrimaryKey { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }

        public static Record GetFromCSV(string recordCSV)
        {
            Record record = null;
            if (!string.IsNullOrEmpty(recordCSV))
            {
                string[] values = recordCSV.Split(",");

                if (values.Length == 4)
                {
                    record = new Record()
                    {
                        PrimaryKey = values[^4],
                        Property1 = values[^3],
                        Property2 = values[^2],
                        Property3 = values[^1]
                    };
                }
            }
            return record;
        }
    }
}

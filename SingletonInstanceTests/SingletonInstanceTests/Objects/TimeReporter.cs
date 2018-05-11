using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonInstanceTests.Objects
{
    public class TimeReporter : ITimeReporter
    {
        public int Id { get; }

        public TimeReporter(int id)
        {
            Id = id;
        }

        public void WriteTime()
        {
            Console.WriteLine($"{Id}: {DateTime.Now.ToString("T")}");
        }
    }
}

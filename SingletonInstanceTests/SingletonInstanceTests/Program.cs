using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonInstanceTests
{
    using System.Threading;
    using Objects;

    public class Program
    {
        public static void Main(string[] args)
        {
            const int threadCount = 3;
            var threads = new Task[threadCount];
            const int threadDelayInSeconds = 5;

            var runnerAction = new Action<TimeReporter>(t =>
            {
                t.WriteTime();
                Thread.Sleep(threadDelayInSeconds * 1000);
                t.WriteTime();
            });

            for(var i = 0; i < threadCount; i++)
            {
                var i1 = i+1;
                threads[i] = new Task(() => runnerAction(new TimeReporter(i1)));
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerProblem
{
    public class Class1
    {
        static Queue<int> numbers = new Queue<int>();

        static Random rand = new Random();

        const int NumThreads = 3;

        static int[] sums = new int[NumThreads];

        static void ProduceNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(rand.Next(10));
                Thread.Sleep(rand.Next(1000));
            }
        }

    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Producer
    {
        public static BlockingCollection<Message> bc = new BlockingCollection<Message>();


        static void Main(string[] args)
        {
            ThreadStart job = new ThreadStart(ThreadJob);
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(job);
                threads[i].Start();
            }
            Console.ReadKey();
        }

        static void ThreadJob()
        {
            var r = new Random();
            Message message;

            for (int i = 0; i < 10; i++)
            {
                message = new Message { TimeStamp = DateTime.Now, Sevirity = r.Next(1, 7), text = "bla" };
                bc.Add(message);
                Console.WriteLine(message.Sevirity + "-->" + bc.Count());
                Thread.Sleep(100);
            }
        }
    }
}


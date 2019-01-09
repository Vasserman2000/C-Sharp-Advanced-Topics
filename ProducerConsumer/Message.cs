using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Message
    {
        public DateTime TimeStamp { get; set; }
        public int Sevirity { get; set; }
        public string text { get; set; }
    }
}

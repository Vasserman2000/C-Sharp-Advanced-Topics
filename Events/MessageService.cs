using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded (object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending message ... " + args.Video.Title);
        }
    }
}

using System;
using System.Threading;

namespace Events
{
    /// <summary>
    /// EVENTS:
    /// - A mechanism for communication between objects
    /// - Used in building Loosely Coupled Applications (components are not tightly coupled together)
    /// - Helps extending application
    /// </summary>
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            // encoding a video ...
            Console.WriteLine("Encoding Video ....");
            Thread.Sleep(3000);

            // notify subscribers that a video has been encoded
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}

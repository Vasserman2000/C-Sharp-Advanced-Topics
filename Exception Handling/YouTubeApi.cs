using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string userName)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of videos
                if (userName == null)
                    throw new Exception("Oops some low level exception occured while accessing videos.");

                return new List<Video>() { new Video(), new Video(), new Video() };
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch videos from YouTube.", ex);
            }
        }
    }
}

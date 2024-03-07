using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Content_Dashboard
{
    internal class Videos : MediaContent
    {
        private double Duration { get; }
        private int Resolution { get; }

        public Videos(string title, string author, DateTime publishDate, int views, int likes, int comments, string contentType, double duration, int resolution) : base(title, author, publishDate, views, likes, comments, contentType)
        {
            Duration = duration;
            Resolution = resolution;
        }
        public override void ShowMediaContentInfo()
        {
            base.ShowMediaContentInfo();
            Console.WriteLine($"{Duration} - {Resolution}");
        }
    }
}

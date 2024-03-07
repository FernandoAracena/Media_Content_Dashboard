using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Content_Dashboard
{
    internal class Images : MediaContent
    {
        private int Resolution { get; }
        private string Format { get; }

        public Images(string title, string author, DateTime publishDate, int views, int likes, int comments, string contentType, int resolution, string format) : base(title, author, publishDate, views, likes, comments, contentType)
        {
            Resolution = resolution;
            Format = format;
        }
        public override void ShowMediaContentInfo()
        {
            base.ShowMediaContentInfo();
            Console.WriteLine($"{Resolution} - {Format}");
        }
    }
}

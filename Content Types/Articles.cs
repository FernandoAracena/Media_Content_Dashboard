using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Content_Dashboard
{
    internal class Articles : MediaContent
    {
        private string Category { get; }
        private int WordCount { get; }

        public Articles(string title, string author, DateTime publishDate, int views, int likes, int comments, string contentType, string category, int wordCount) : base(title, author, publishDate, views, likes, comments, contentType)
        {
            Category = category;
            WordCount = wordCount;
        }
        public override void ShowMediaContentInfo()
        {
            base.ShowMediaContentInfo();
            Console.WriteLine(Category, WordCount);
        }
    }
}

using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard.Commands
{
    internal class AddMediaContentCommand : Command
    {
        private readonly DashboardController _contentList;
        public AddMediaContentCommand(DashboardController contentList) : base("1", "AddMediaContent")
        {
            _contentList = contentList;
        }

        public override void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Input a title :");
            string title = Console.ReadLine();
            Console.WriteLine("Input a author :");
            string author = Console.ReadLine();
            Console.WriteLine("Input a publish date :");
            DateTime publish = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input numbers of views :");
            int views = int.Parse(Console.ReadLine());
            Console.WriteLine("Input numbers of likes :");
            int likes = int.Parse(Console.ReadLine());
            Console.WriteLine("Input numbers of comments :");
            int comments = int.Parse(Console.ReadLine());
            Console.WriteLine("Input type of content :");
            Console.WriteLine("Articles - Images - Videos :");
            string contenttype = Console.ReadLine();
            if (contenttype == "Articles")
            {
                Console.WriteLine("Input Category :");
                string category = Console.ReadLine();
                Console.WriteLine("Input Word Count :");
                int wordcount = int.Parse(Console.ReadLine());
                var article = new Articles(title, author, publish, views, likes, comments, contenttype, category, wordcount);
                _contentList.AddNewMediaContent(article);
                Console.WriteLine("Info about added Conetnt :");
                article.ShowMediaContentInfo();
            }
            else if (contenttype == "Images")
            {
                Console.WriteLine("Input Resolution :");
                int resolution = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Format :");
                string format = Console.ReadLine();
                var image = new Images(title, author, publish, views, likes, comments, contenttype, resolution, format);
                _contentList.AddNewMediaContent(image);
                Console.WriteLine("Info about added Conetnt :");
                image.ShowMediaContentInfo();
            }
            else if (contenttype == "Videos")
            {
                Console.WriteLine("Input Duration in hours :");
                double duration = double.Parse(Console.ReadLine());
                Console.WriteLine("Input Resolution :");
                int resolution = int.Parse(Console.ReadLine());
                var video = new Videos(title, author, publish, views, likes, comments, contenttype, duration, resolution);
                _contentList.AddNewMediaContent(video);
                Console.WriteLine("Info about added Conetnt :");
                video.ShowMediaContentInfo();
            }
            Console.WriteLine();
        }
    }
}

using Media_Content_Dashboard_DI;
namespace Media_Content_Dashboard
{
    internal class MediaContent : IMediaContent
    {
        private string Title { get; }
        private string Author { get; }
        private DateTime PublishDate { get; }
        private int Views { get; }
        private int Likes { get; }
        private int Comments { get; }
        private string ContentType { get; }
        public MediaContent(string title, string author, DateTime publishDate, int views, int likes, int comments, string contentType)
        {
            Title = title;
            Author = author;
            PublishDate = publishDate;
            Views = views;
            Likes = likes;
            Comments = comments;
            ContentType = contentType;
        }
        public virtual void ShowMediaContentInfo()
        {
            Console.WriteLine($"Title : {Title} - Author : {Author} - Publish Date : {PublishDate} - Views : {Views} - Likes : {Likes} - Comments : {Comments} - ContentType : {ContentType}");
        }
        public string ShowContentType()
        {
            return ContentType;
        }
        public int ShowTotalReactions()
        {
            return Views + Likes + Comments;
        }
    }
}

using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard.Commands
{
    internal class DisplayAllMediaContentCommand : Command
    {
        private readonly DashboardController _contentList;
        public DisplayAllMediaContentCommand(DashboardController contentList) : base("2", "DisplayAllMediaContent")
        {
            _contentList = contentList;
        }

        public override void Run()
        {
            _contentList.DisplayListMediaContent();
        }
    }
}

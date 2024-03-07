using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard.Commands
{
    internal class DisplayStatisticsCommand :Command
    {
        private readonly DashboardController _contentList;
        public DisplayStatisticsCommand(DashboardController contentList) : base("3", "DisplayStatistics")
        {
            _contentList = contentList;
        }

        public override void Run()
        {
            Console.WriteLine("Total numbers of items :");
            _contentList.TotalNumberOfItems();
            Console.WriteLine("Total reactions :");
            _contentList.TotalReactionsMediaItems();
        }
    }
}

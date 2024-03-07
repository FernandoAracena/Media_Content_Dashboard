using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard.Commands
{
    internal class FilterMediaContentByTypeCommand : Command
    {
        private readonly DashboardController _contentList;
        public FilterMediaContentByTypeCommand(DashboardController contentList) : base("4", "FilterMediaContentByType")
        {
            _contentList = contentList;
        }

        public override void Run()
        {
            Console.WriteLine("Input filter :");
            Console.WriteLine("Articles - Videos - Images");
            string filter = Console.ReadLine();
            Console.WriteLine($"List of all {filter}");
            _contentList.FilterByMediaContent(filter);
        }
    }
}

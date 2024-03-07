using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard.Commands
{
    internal class RemoveMediaContentCommand : Command
    {
        private readonly DashboardController _contentList;
        public RemoveMediaContentCommand(DashboardController contentList) : base("5", "RemoveMediaContent")
        {
            _contentList = contentList;
        }

        public override void Run()
        {
            _contentList.DisplayListMediaContent();
            Console.WriteLine("Input the index for the Item you want to Remove :");
            int index = int.Parse(Console.ReadLine());
            _contentList.RemoveMediaContentByIndex(index);
        }
    }
}

using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard
{
    abstract class Command
    {
        public string No { get; }
        public string Description { get; }
        public Command(string no, string description)
        {
            No = no;
            Description = no + " - " + description;
        }
        public abstract void Run();
    }
}

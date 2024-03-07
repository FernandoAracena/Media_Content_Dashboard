using Media_Content_Dashboard.Commands;
using Media_Content_Dashboard_DI;

namespace Media_Content_Dashboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            var contentlist = new DashboardController();
            var commands = new Command[]
            {
                new AddMediaContentCommand(contentlist),
                new DisplayAllMediaContentCommand(contentlist),
                new DisplayStatisticsCommand(contentlist),
                new FilterMediaContentByTypeCommand(contentlist),
                new RemoveMediaContentCommand(contentlist)
            };
            while (true)
            {
                foreach (var command in commands)
                {
                    Console.WriteLine(command.Description);
                }
                var cmd = Console.ReadLine();
                var cmdSelected = commands.SingleOrDefault(c => c.No == cmd);
                cmdSelected.Run();
            }
        }
    }
}
//#### Requirements:
//1. Implement classes/interfaces for media content types like Articles, Videos, and Images.
//2. Each media content type should have properties like Title, Author, Publish Date, Views, Likes, Comments, etc.
//3. Implement a central controller (`DashboardController`) to manage the dashboard functionalities.
//4. Implement the following functionalities:
//   -Add new media content(Articles, Videos, Images).
//   -Display a list of all added media content.
//   - Filter media content by type (Articles, Videos, Images).
//   -Display statistics:
//   -Total number of media items.
//   - Total views, likes, and comments across all media items.
//   - Allow users to remove media content by index.

//#### Classes/Interfaces:
//- `IMediaContent` (Interface)
//  -Properties: `Title`, `Author`, `PublishDate`, `Views`, `Likes`, `Comments`
//- `Article` (Class, implements `IMediaContent`)
//  -Additional properties: `Category`, `WordCount`
//- `Video` (Class, implements `IMediaContent`)
//  -Additional properties: `Duration`, `Resolution`
//- `Image` (Class, implements `IMediaContent`)
//  -Additional properties: `Resolution`, `Format`

//#### Controller:
//- `DashboardController`
//  - Methods:
//    - `AddMediaContent(IMediaContent mediaContent)`
//    - `DisplayAllMediaContent()`
//    - `FilterMediaContentByType(string mediaType)`
//    - `DisplayStatistics()`
//    - `RemoveMediaContent(int index)`

//#### Console Application Flow:
//1.Present a menu with options to:
//   -Add new media content.
//   - Display all media content.
//   - Filter media content by type.
//   - Display statistics.
//   - Remove media content.
//   - Exit the application.
//2. Based on the user's input, perform the corresponding action using the `DashboardController` methods.

//#### Tips:
//- Use inheritance and interfaces to create a flexible and scalable design.
//- Implement error handling for user input (e.g., invalid menu choices, incorrect data types).
//-Create sample data to seed the application for testing purposes.
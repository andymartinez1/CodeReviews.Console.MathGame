Console.WriteLine("Please type your name:");

var name = Console.ReadLine();
var date = DateTime.Now;

void Menu(string? name, DateTime date)
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine($"Hello {name}! It's {date.DayOfWeek}.");
    Console.WriteLine(@"What game would you like to play? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
E - Exit");
    Console.WriteLine("----------------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame();
            break;
        case "s":
            SubtractionGame();
            break;
        case "m":
            MultiplicationGame();
            break;
        case "d":
            DivisionGame();
            break;
        case "e":
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("You did not enter a valid option");
            break;
    }
}

void AdditionGame()
{
    Console.WriteLine("Addition Game selected");
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction Game selected");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication Game selected");
}

void DivisionGame()
{
    Console.WriteLine("Division Game selected");
}
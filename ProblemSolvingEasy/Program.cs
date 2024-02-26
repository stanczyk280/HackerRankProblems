using ProblemSolvingEasy;

List<string> options = new List<string>
{
    "1. SolveMeFirst",
    "2. Time Conversion",
    "3. Simple Array Sum",
    "0. Exit"
};

void DisplayMenu()
{
    foreach (string option in options)
    {
        Console.WriteLine(option);
    }

    Console.WriteLine("Input option number: ");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.WriteLine("The answer is: " + SolveMeFirst.SolveMeFirstMethod(3, 7));
            ReturnToMenu();
            break;

        case "2":
            Console.WriteLine("The answer is: " + TimeConversion.ConvertTime("07:01:00AM"));
            ReturnToMenu();
            break;

        case "3":
            Console.WriteLine("The answer is: " + SimpleArraySum.SumArray(new List<int> { 1, 2, 3, 4, 10, 11 }));
            ReturnToMenu();
            break;

        case "0":
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid option. Please enter a valid number.");
            ReturnToMenu();
            break;
    }
}

void ReturnToMenu()
{
    Console.WriteLine("Press any key to return to menu");
    Console.ReadLine();
    Console.Clear();
    DisplayMenu();
}

DisplayMenu();
using ProblemSolvingEasy;

List<string> options = new List<string>
{
    "1. SolveMeFirst",
    "2. Time Conversion",
    "3. Simple Array Sum",
    "4. CompareTheTriplets",
    "5. A Very Big Sum",
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

        case "4":
            List<int> score = CompareTheTriplets.CompareTriplets(new List<int> { 5, 6, 7 }, new List<int> { 3, 6, 10 });
            Console.WriteLine("The answer is: " + score[0] + " " + score[1]);
            ReturnToMenu();
            break;

        case "5":
            Console.WriteLine("The answer is: " + VeryBigSum.CalculateSum(new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }));
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
Console.WriteLine("Hello!");
Console.WriteLine("What do you  want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userInput = Console.ReadLine().ToUpper();

if (userInput == "S")
{
    PrintSelectedOption("See all TODOs");
}
else if (userInput == "A")
{
    PrintSelectedOption("Add a TODOs");
}
else if (userInput == "R")
{
    PrintSelectedOption("Remove a TODOs");
}
else if (userInput == "E")
{
    PrintSelectedOption("Exit");
}
// to keep Windows terminal open
Console.ReadKey();

// Method to display what option the user selected
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine($"Selected option: {selectedOption}");
}
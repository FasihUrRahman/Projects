//Variables
string? userInput, askIsContinue;
bool isContinue = true;
//Code
while (isContinue)
{
    Console.WriteLine("Enter You Message Here");
    Console.Write(">>");
    userInput = Console.ReadLine();
    while (userInput.Contains("  "))
    {
        userInput = userInput.Replace("  ", " ");
    }
    Console.WriteLine($"ExtraSpaces are Removed From The String \"{userInput}\"");
    Console.Write("Do You want To restart?(y/n): ");
    askIsContinue = Console.ReadLine();
    if (askIsContinue.ToLower() != "y")
        isContinue = false;
    Console.Clear();
}

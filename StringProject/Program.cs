//Variables
string? userInput, askContinue;
bool isContinue;
//Array
string[] words;
//Code
do
{
    Console.WriteLine("Enter Your Message To Count The Words");
    Console.Write(">>");
    userInput = Console.ReadLine();
    if (userInput != "")
    {
        words = userInput.Split(" ");
        Console.WriteLine($"The Words in This String are {words.Length}.");
    }
    else
    {
        Console.WriteLine("Please Input Some Value");
    }
    Console.Write("Do you wanna restart it?(Y = Yes | N = No): ");
    askContinue = Console.ReadLine();
    if( askContinue.ToLower() == "y")
    {
        isContinue = true;
        Console.Clear();
    }
    else
    {
        isContinue = false;
    }
} while (isContinue);

//Variables
string? userInput, keyWord, askIsContinue;
int keyWordCounter = 0;
bool isContinue = true;
//Code
while (isContinue)
{
    Console.WriteLine("Enter Your Message");
    Console.Write(">>");
    userInput = Console.ReadLine();
    Console.WriteLine("Which Word You Willing To Count?");
    Console.Write(">>");
    keyWord = Console.ReadLine();

    for (int i = 0; i < userInput.Length; i++)
    {
        if (userInput.IndexOf(keyWord, i) == i)
        {
            keyWordCounter++;
        }
    }
    if (keyWordCounter != 0)
        Console.WriteLine($"The Word \"{keyWord}\" is Used {keyWordCounter} Times in This Input.");
    else
        Console.WriteLine("No keyWord Found");
    Console.Write("Do You wanna Restart?(Y/N): ");
    askIsContinue = Console.ReadLine();
    if(askIsContinue.ToLower() != "y")
    {
        isContinue = false;
    }
    Console.Clear();
    keyWordCounter = 0;
}

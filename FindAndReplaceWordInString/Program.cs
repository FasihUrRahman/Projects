//Variables
string? userInput, keyWordToFind, keyWordToReplace, askIsContinue;
bool isContinue = true;
//Code
//Loop To Restart Code
while (isContinue)
{
    //Input From User
    Console.WriteLine("Enter Your Message");
    Console.Write(">>");
    userInput = Console.ReadLine();
    Console.WriteLine("Which Word You Willing To Find?");
    Console.Write(">>");
    keyWordToFind = Console.ReadLine();
    Console.WriteLine("Which Word You Willing To Replace?");
    Console.Write(">>");
    keyWordToReplace = Console.ReadLine();
    //Replace KeyWord
    while (userInput.Contains(keyWordToFind))
    {
        userInput = userInput.Replace(keyWordToFind, keyWordToReplace);
    }
    //OutPut
    Console.WriteLine($"Your New Message is\"{userInput}\"");
    Console.WriteLine("Do You Want To Restart Software?(y/n): ");
    askIsContinue = Console.ReadLine();
    if(askIsContinue != "y")
        isContinue = false;
    Console.Clear();
}

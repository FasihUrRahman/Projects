//Attached Files
using StringPrintToEverySecondChar;
//Objects
ShuffalString stringMethods = new ShuffalString();
//Variables
string userInput = null;
//Code
Console.Write("Enter String: ");
userInput = Console.ReadLine();
stringMethods.InputShuffal(userInput);
Console.ReadLine();
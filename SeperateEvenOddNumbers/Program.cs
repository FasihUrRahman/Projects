//NameSpaces
using SeperateEvenOddNumbers;
//Objects
EvenOddSeperator seperator = new EvenOddSeperator();
//Variables
int[] userInputValues = new int[10];
//Code
for (int i = 0;i<userInputValues.Length; i++)
{
    Console.Write($"Enter {i+1} Input: ");
    userInputValues[i] = int.Parse(Console.ReadLine());
    Console.Clear();
}
//Functions
seperator.OutputArray(userInputValues);
seperator.EvenValue(userInputValues);
seperator.OddValue(userInputValues);
Console.ReadLine();
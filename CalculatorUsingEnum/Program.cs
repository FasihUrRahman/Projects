
using CalculatorUsingEnum;
//Variables
int userInput1, userInput2, userSelector, result = 0;
//Code
Console.Write("Enter First Value: ");
userInput1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second Value: ");
userInput2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{(int)Actions.Add} - {Actions.Add}\n{(int)Actions.Subtract} - {Actions.Subtract}\n{(int)Actions.Multiply} - {Actions.Multiply}\n{(int)Actions.Divide} - {Actions.Divide}\n{(int)Actions.Modulo} - {Actions.Modulo}");
Console.Write(">>");
userSelector = Convert.ToInt32(Console.ReadLine());
switch (userSelector)
{
    case (int)Actions.Add:
        result = userInput1 + userInput2;
        break;
    case (int)Actions.Subtract:
        result = userInput1 + userInput2;
        break;
    case (int)Actions.Multiply:
        result = userInput1 + userInput2;
        break;
    case (int)Actions.Divide:
        result = userInput1 + userInput2;
        break;
    case (int)Actions.Modulo:
        result = userInput1 + userInput2;
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
Console.WriteLine($"Your Answer is {result}");
Console.ReadLine();
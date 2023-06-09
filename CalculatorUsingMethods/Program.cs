//File Links
using CalculatorUsingMethods;
//Object
Calculator Cal = new Calculator();
//Variables
double userInput1, userInput2, result;
int selctor;
//Code
Console.Write("Enter First Value: ");
userInput1 = double.Parse(Console.ReadLine());
Console.Write("Enter Second Value: ");
userInput2 = double.Parse(Console.ReadLine());
Console.WriteLine("Select Option\n1 - Add\n2 - Subtract\n3 - Multiply\n4 - Divide\n5 - Modulus");
Console.Write(">>");
selctor = int.Parse(Console.ReadLine());
switch (selctor)
{
    case 1:
        result = Cal.Add(userInput1,userInput2);
        Console.Write($"Your Answer is {userInput1} + {userInput2} = {result}");
        break;
    case 2:
        result = Cal.Subtract(userInput1, userInput2);
        Console.Write($"Your Answer is {userInput1} - {userInput2} = {result}");
        break;
    case 3:
        result = Cal.Multiply(userInput1, userInput2);
        Console.Write($"Your Answer is {userInput1} * {userInput2} = {result}");
        break;
    case 4:
        result = Cal.Divide(userInput1, userInput2);
        Console.Write($"Your Answer is {userInput1} / {userInput2} = {result}");
        break;
    case 5:
        result = Cal.Modulus(userInput1, userInput2);
        Console.Write($"Your Answer is {userInput1} % {userInput2} = {result}");
        break;
    default:
        Console.Write("Invalid Input");
        break;
}
Console.ReadKey();
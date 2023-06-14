//Linked Files
using CalculatorWithClass;
//Objects
Calculator cal = new Calculator();
//Variables
double value1, value2;
int selector;
//Code
Console.Write("Enter First Value: ");
value1 = int.Parse(Console.ReadLine());
Console.Write("Enter Second Value: ");
value2 = int.Parse(Console.ReadLine());
cal.SetValue(value1, value2);
Console.Write("----Select Option----\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - Modulus\n>> ");
selector = int.Parse(Console.ReadLine());
switch (selector)
{
    case 1:
        cal.Add();
        break;
    case 2:
        cal.Subtract();
        break;
    case 3:
        cal.Multiply();
        break;
    case 4:
        cal.Divid();
        break;
    case 5:
        cal.Modules();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
Console.ReadLine();
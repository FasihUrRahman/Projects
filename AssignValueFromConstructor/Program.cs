//File Attached
using AssignValueFromConstructor;
//Code
Console.Write("Enter Name: ");
string name = Console.ReadLine();
Console.Write("Enter Age: ");
int age = int.Parse(Console.ReadLine());
Console.Write("Enter Gender(M/F/Any Other Key): ");
char gender = Console.ReadKey().KeyChar;
Console.WriteLine();
Person info = new Person(name,age, gender);
Console.Write($"Your Name is {info.GetName()}. Your Age is {info.GetAge()}. ");
if (info.GetGender() == 'm')
{
    Console.Write($"Your Gender is Male");
}
else if(info.GetGender() == 'f')
{
    Console.Write($"Your Gender is Female");
}
else
{
    Console.Write($"Your Gender is Unknow");
}
Console.ReadLine();
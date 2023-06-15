//Link Files
using StudentInfoGetherWithMarks;
//Object
Student std = new Student();
//Variables
string stdName;
int stdClass,stdAge;
int[] stdMarks = new int[5];
//Code
Console.Write("Enter Student Name: ");
stdName = Console.ReadLine();
Console.Write("Enter Student Class: ");
stdClass = int.Parse(Console.ReadLine());
Console.Write("Enter Student Age: ");
stdAge = int.Parse(Console.ReadLine());
for (int i = 0; i <stdMarks.Length; i++)
{
    Console.Write($"Enter Marks For {i+1} Subject: ");
    stdMarks[i] = int.Parse(Console.ReadLine());
}
std.SetInfo(stdName,stdClass,stdAge,stdMarks);
Console.Clear();
std.GetInfo();
Console.ReadLine();

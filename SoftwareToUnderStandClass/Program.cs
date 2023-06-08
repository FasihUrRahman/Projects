//Linked Files
using SoftwareToUnderStandClass;
//Variables
int selector;
//Code
Console.WriteLine("Select an Option");
Console.WriteLine("----------");
Console.WriteLine($"{(int)Option.Student} - {Option.Student}\n{(int)Option.Product} - {Option.Product}\n{(int)Option.Food} - {Option.Food}");
Console.Write(">>");
selector = Convert.ToInt32(Console.ReadLine());
Console.Clear();
switch (selector)
{
    case (int)Option.Student:
        //Code
        Console.WriteLine("Select an Option");
        Console.WriteLine("----------");
        Console.WriteLine($"{(int)SubOptionForStudent.Create} - {SubOptionForStudent.Create}\n{(int)SubOptionForStudent.View} - {(int)SubOptionForStudent.View}\n{SubOptionForStudent.Delete} - {SubOptionForStudent.Delete}");
        Console.Write(">>");
        selector = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (selector)
        {
            case (int)SubOptionForStudent.Create:
                //Code
                Console.WriteLine("Lora mera");
                break;
            case (int)SubOptionForStudent.View: 
                //Code
                break;
            case (int)SubOptionForStudent.Delete: 
                //Code
                break;
        }
        break;
    case (int)Option.Product: 
        //Code
        break;
    case (int)Option.Food: 
        //Code
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
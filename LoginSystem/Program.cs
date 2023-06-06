//Files To Connect
using LoginSystem;
//Class Objects
Login info = new Login();

//Code
Console.WriteLine("\tLogin System");
Console.Write("Enter Email:");
info.Email = Console.ReadLine();
if (info.Email != "")
{
    Console.Write("Enter Username:");
    info.UserName = Console.ReadLine();
    if (info.UserName != "")
    {
        Console.Write("Enter Password:");
        info.Password = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Please Give Some Input");
    }
}
else
{
    Console.WriteLine("Please Give Some Input");
}
if (info.CheckUserName() && info.CheckUserEmail() && info.CheckUserPassword())
{
            Console.WriteLine($"Hello {info.UserName}");
            Console.WriteLine($"Your Email is {info.Email}");
}
else
{
    Console.WriteLine("Invalid Details");
}
Console.ReadLine();
//Variables
int year, month, day;
DateTime dateOfBirth, latestDate = DateTime.Today;
TimeSpan ageInDays,ageInYears;
//Code
Console.WriteLine("Enter Your Age");
Console.Write("Year: ");
year = Convert.ToInt32(Console.ReadLine());
Console.Write("Month: ");
month = Convert.ToInt32(Console.ReadLine());
Console.Write("Day: ");
day = Convert.ToInt32(Console.ReadLine());
dateOfBirth = new DateTime(year, month, day);
ageInDays = latestDate.Subtract(dateOfBirth);
ageInYears = ageInDays / 365.25;
Console.WriteLine($"Your Age Is {ageInYears.Days} Years.");
if(ageInYears.Days <= 10)
{
    Console.WriteLine("You are Baby");
}
else if(ageInYears.Days <= 20)
{
    Console.WriteLine("You are Immature");
}
else if(ageInYears.Days <= 30)
{
    Console.WriteLine("You are Adult");
}
else if(ageInYears.Days <= 40)
{
    Console.WriteLine("You are Superior");
}
Console.ReadLine();
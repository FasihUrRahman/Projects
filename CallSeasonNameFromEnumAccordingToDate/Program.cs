//OutSource Files
using CallSeasonNameFromEnumAccordingToDate;

//Variables
DateTime userInput; //DateTime dt = new DateTime(2023, 08, 20) 
int month;
//Code
Console.Write("Please Enter Date(YYYY MM DD): ");
userInput = Convert.ToDateTime(Console.ReadLine());
month = userInput.Month;

if(month < (int)Month.February || month == (int)Month.December)
{
    Console.WriteLine($"This Season is {Season.Winter}");
}
else if(month < (int)Month.May)
{
    Console.WriteLine($"This Season is {Season.Spring}");
}
else if (month < (int)Month.August)
{
    Console.WriteLine($"This Season is {Season.Summer}");
}
else
{
    Console.WriteLine($"This Season is {Season.Autumns}");
}
Console.ReadLine();
//Arrays
string[] daysName = Enum.GetNames(typeof(DayOfWeek));
//Code
foreach(string dayName in daysName)
{
    if (dayName == DateTime.Today.DayOfWeek.ToString())
    {
        Console.WriteLine($"Today is {dayName}");
    }
}
Console.ReadLine();
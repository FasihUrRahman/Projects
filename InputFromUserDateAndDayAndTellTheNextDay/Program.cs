int year, month, day, nextDay;
DateTime date;
Console.WriteLine("Enter Your Age");
Console.Write("Year: ");
year = Convert.ToInt32(Console.ReadLine());
Console.Write("Month: ");
month = Convert.ToInt32(Console.ReadLine());
Console.Write("Day: ");
day = Convert.ToInt32(Console.ReadLine());
Console.Write("NextDay: ");
nextDay = Convert.ToInt32(Console.ReadLine());
date = new DateTime(year, month, day);
if(nextDay != null)
{
    date = date.AddDays(nextDay);
}
Console.WriteLine($"The Date After {nextDay} Days is {date.Day} and {date.DayOfWeek} is The Day.");
Console.ReadLine();
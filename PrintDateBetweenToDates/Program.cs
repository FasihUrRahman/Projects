DateTime firstDate, secondDate;
Console.Write("Enter First Date(yyyy mm dd): ");
firstDate = Convert.ToDateTime(Console.ReadLine());
Console.Write("Enter Second Date(yyyy mm dd): ");
secondDate = Convert.ToDateTime(Console.ReadLine());
if(firstDate > secondDate)
{
    while(secondDate <= firstDate)
    {
        Console.WriteLine($"Date = {secondDate.ToString("d")} and The Day is {secondDate.DayOfWeek}");
        secondDate = secondDate.AddDays(1);
    }
}
else
{
    while (firstDate <= secondDate)
    {
        Console.WriteLine($"Date = {firstDate.ToString("d")} and The Day is {firstDate.DayOfWeek}");
        firstDate = firstDate.AddDays(1);
    }
}
Console.ReadLine();
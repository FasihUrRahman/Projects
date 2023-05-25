int after15Days = 15;
DateTime userInputDate;
Console.Write("Enter Date(yyyy mm dd): ");
userInputDate = Convert.ToDateTime(Console.ReadLine());
userInputDate = userInputDate.AddDays(after15Days);

Console.Write($"After 15 Days The Date is {userInputDate.ToString("d")} And This will be {userInputDate.DayOfYear} day of the year");
Console.ReadLine();
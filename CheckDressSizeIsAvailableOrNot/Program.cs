using CheckDressSizeIsAvailableOrNot;
//Variables
int userSelector;
//Code
Console.WriteLine($"Enter What Size You Looking For:\n{(int)DressSize.S} - {DressSize.S} Size\n{(int)DressSize.M} - {DressSize.M} Size\n{(int)DressSize.L} - {DressSize.L} Size\n{(int)DressSize.XL} - {DressSize.XL} Size");
Console.Write(">>");
userSelector = Convert.ToInt32(Console.ReadLine());
switch (userSelector)
{
    case (int)DressSize.S:
        Console.WriteLine("Dress Size Small Are Available");
        break;
    case (int)DressSize.M:
        Console.WriteLine("Dress Size Medium Are Not Available");
        break;
    case (int)DressSize.L:
        Console.WriteLine("Dress Size Large Are Available");
        break;
    case (int)DressSize.XL:
        Console.WriteLine("Dress Size Extra Large Are Not Available");
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
Console.ReadLine();
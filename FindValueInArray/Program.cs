int findValue, index = -1;
int[] userInput = {239, 23,22 ,52,15,62,61,53,30 };
Console.WriteLine("What Number You Are Looking For");
Console.Write(">>");
findValue = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] == findValue)
    {
        index = i;
        Console.Write($"Your Value {findValue} is at {index} Index in Array");
    }
}
if (index == -1)
{
    Console.Write($"Your Value {findValue} isn't Found");
}
Console.ReadLine();
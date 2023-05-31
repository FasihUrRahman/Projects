//Variables
int[] userInputs = { 20,10,20,10,10,20,20,30,30,40,40,50,50,60};
int value, counter = 0;
//Code
Console.WriteLine("Enter The Value You Are looking For");
Console.Write(">>");
value = Convert.ToInt32(Console.ReadLine());
//Results
for (int i = 0; i < userInputs.Length; i++)
{
    Console.WriteLine($"Your Value is {userInputs[i]} at {i}");
    if (userInputs[i] == value)
    {
        counter++;
    }
}
if(counter != 0)
{
    Console.WriteLine($"The Value You Entered Are {counter} Time Used in Array");
}
else
{
    Console.WriteLine("The Value You Entered Not Found");
}
Console.ReadLine();
string userInput = "Ali";
char[] reverse = new char[userInput.Length];
int j = 0;
for(int i = userInput.Length-1; i >= 0; i--)
{
    reverse[j] = userInput[i];
    j++;

}
Console.ReadLine();
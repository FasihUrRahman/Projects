int[] userInput = {20,30,10,1,25,30};
int[] sortedValuesSmalltoBig = SortArraySmallToBig(userInput);

for (int i = 0; i < sortedValuesSmalltoBig.Length; i++)
{ Console.WriteLine(sortedValuesSmalltoBig[i]); }



Console.ReadLine();
static int[] SortArraySmallToBig(int[] array)
{
    int smallValue;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                smallValue = array[i];
                array[i] = array[j];
                array[j] = smallValue;
            }
        }
    }
    return array;
}
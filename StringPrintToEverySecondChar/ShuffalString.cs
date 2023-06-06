namespace StringPrintToEverySecondChar
{
    internal class ShuffalString
    {
        internal void InputShuffal(string value)
        {
            for (int i = 0; i < value.Length; i+=2)
            {
                Console.Write(value[i]);
            }
            for (int i = 1; i < value.Length; i+=2)
            {
                    Console.Write(value[i]);
            }
        }
    }
}

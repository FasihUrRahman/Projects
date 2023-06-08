namespace SeperateEvenOddNumbers
{
    internal class EvenOddSeperator
    {
        public void OutputArray(int[] value)
        {
            Console.Write("Array{ ");
            foreach (int item in value)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");

        }
        public void EvenValue(int[] values) 
        {
            Console.WriteLine("Even Numbers");
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    Console.WriteLine($"{values[i]} is At Index of {i}");
                }
            }
        }
        public void OddValue(int[] values)
        {
            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 != 0)
                {
                    Console.WriteLine($"{values[i]} is At Index of {i}");
                }
            }
        }
    }
}

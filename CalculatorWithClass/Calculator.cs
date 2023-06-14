namespace CalculatorWithClass
{
    internal class Calculator
    {
        private double value1;
        private double value2;
        public void SetValue(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public void Add()
        {
            Console.WriteLine($"{value1} + {value2} = {value1+value2}");
        }
        public void Subtract()
        {
            Console.WriteLine($"{value1} - {value2} = {value1 - value2}");
        }
        public void Multiply()
        {
            Console.WriteLine($"{value1} x {value2} = {value1 * value2}");
        }
        public void Divid()
        {
            Console.WriteLine($"{value1} / {value2} = {value1 / value2}");
        }
        public void Modules()
        {
            Console.WriteLine($"{value1} % {value2} = {value1 % value2}");
        }
    }
}

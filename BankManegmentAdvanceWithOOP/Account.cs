namespace BankManegmentAdvanceWithOOP
{
    internal class Account
    {
        private int id = 0;
        public double balance = 500;
        private double deposit;
        private double withdraw;
        private string[,] history = new string[30, 5];
        public double Deposit
        {
            get { return deposit; }
            set
            {
                if (value < 0)
                {
                    Console.Write("Invalid Balance");
                }
                else
                {
                    deposit = value;
                    balance += deposit;
                    Console.Write($"Balance is Deposit. Your new balance is {balance} after Deposit {value}");
                    SetHistory(balance, deposit, "Deposit");
                }
            }
        }
        public double Withdraw
        {
            get { return withdraw; }
            set 
            {
                if (value > 0 && value < balance)
                {
                    withdraw = value;
                    balance -= withdraw;
                    Console.Write($"Balance is Withdraw. Your new balance is {balance} after Withdraw {value}");
                    SetHistory(balance, withdraw, "Withdraw");
                }
                else
                {
                    Console.Write("Invalid Balance");
                }
            }
        }
        private void SetHistory(double balance, double value, string action)
        {
            history[id, 0] = id.ToString();
            history[id, 1] = value.ToString();
            history[id, 2] = balance.ToString();
            history[id, 3] = action;
            history[id, 4] = DateTime.Now.ToString("d");
            id++;
        }
        public string[,] GetHistory()
        {
            return history;
        }
    }
}

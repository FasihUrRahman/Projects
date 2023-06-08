//Files To Link
using BankManegmentAdvanceWithOOP;
//Object
Account bank = new Account();
//Variables
double userAccountNumber;
int selector, userAccountPin, counter = 1;
bool isContinue = true, loginRepeter = false;
string[,] history;
//Code
while(isContinue)
{
    Console.WriteLine("The Bank\n---------\n1 - Login\n2 - Exit");
    Console.Write(">>");
    selector = int.Parse(Console.ReadLine());
    switch (selector)
    {
        case 1:
            if(counter == 3)
            {
                isContinue = false;
                Console.WriteLine("You Entered Wrong Details Many Time, Please Contact to The Bank");
                Console.ReadLine();
                break;
            }
            Console.Write("Enter Your Account Number(Must Be 11 Digit): ");
            userAccountNumber = double.Parse(Console.ReadLine());
            if(userAccountNumber.ToString().Length == 11)
            {
                Console.Write("Enter Pin(Must Be 4 Digit): ");
                userAccountPin = int.Parse(Console.ReadLine());
                if(userAccountPin.ToString().Length == 4)
                {
                    if (userAccountNumber == 12345678901 && userAccountPin == 1234)
                    {
                        loginRepeter = true;
                    }
                    else
                    {
                        loginRepeter = false;
                        counter++;
                    }
                }
                else
                {
                    Console.Write("Invalid Input");
                    counter++;
                }
            }
            else
            {
                Console.Write("Invalid Input");
                counter++;
            }
            while (loginRepeter)
            {
                Console.Clear();
                Console.WriteLine("The Bank\n---------\n1 - Balance\n2 - Deposit\n3 - Withdraw\n4 - History\n5 - Logout");
                Console.Write(">>");
                selector = int.Parse(Console.ReadLine());
                switch (selector)
                {
                    case 1:
                        Console.Write($"Your Balance is {bank.balance}");
                        break;
                    case 2:
                        Console.Write("Enter Balance To Deposit: ");
                        bank.Deposit = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Enter Balance To Withdraw: ");
                        bank.Withdraw = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        history = bank.GetHistory();
                        for(int i = 0; i < history.Length; i++)
                        {
                            if (history[i, 1] != null)
                            {
                                Console.WriteLine($"{history[i, 0]}\t{history[i, 1]}\t{history[i, 2]}\t{history[i, 3]}\t{history[i, 4]}");
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 5:
                        loginRepeter = false;
                        Console.Write("Logged Out");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ReadLine();
            }
            Console.ReadLine();
            break;
        case 2:
            isContinue = false;
            Console.Write("Thanks For Using This...");
            Console.ReadLine();
            break;
        default:
            Console.Write("Invalid Input");
            Console.ReadLine();
            break;
    }
    Console.Clear();
}
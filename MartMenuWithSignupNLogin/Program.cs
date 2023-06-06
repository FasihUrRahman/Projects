//Linked Files
using MartMenuWithSignupNLogin;
//Objects
Signup info = new Signup();
//Variables
int selector;
bool isContinue = true, passwordCheck = true;
string purchaseItem, userName = null, password = null;
string passwordCheck1;
//Code
while (isContinue)
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("--------");
    Console.WriteLine("1 - Sign Up\n2 - Login\n3 - Exit");
    Console.Write(">>");
    selector = int.Parse(Console.ReadLine());
    switch (selector)
    {
        case 1:
            if (info.UserName == "")
            {
                Console.WriteLine("You Already Signup");
            }
            else
            {
                Console.Write("Enter Full Name: ");
                info.FullName = Console.ReadLine();
                Console.Write("Enter User Name: ");
                info.UserName = Console.ReadLine();
                Console.Write("Enter Email: ");
                info.Email = Console.ReadLine();
                Console.Write("Enter Password: ");
                info.Password = Console.ReadLine();
                Console.Clear();
                Console.Write($"Welcome {info.FullName}");
            }
            break;
        case 2:
            Console.Write("Enter User Name: ");
            userName = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            passwordCheck = info.CheckPassword(userName, password);
            Console.WriteLine(passwordCheck);
            Console.ReadLine();
            if (passwordCheck)
            {
                while (passwordCheck)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome Back {userName}");
                    Console.WriteLine("Food Menu\n--------\n1 - Food\n2 - Drinks\n3 - exit");
                    Console.Write(">>");
                    selector = int.Parse(Console.ReadLine());
                    switch (selector)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Food Menu\n--------\n1 - Pizza\n2 - Wraps\n3 - Pasta");
                            Console.Write(">>");
                            selector = int.Parse(Console.ReadLine());
                            switch (selector)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Price For The Pizza is PKR1199. ");
                                    Console.Write("Are You willing To buy?(Y/N): ");
                                    purchaseItem = Console.ReadLine();
                                    if (purchaseItem.ToLower() == "y")
                                    {
                                        Console.Write("Thanks For Buying The Item Your Bill is PKR1199.");
                                    }
                                    else if (purchaseItem.ToLower() == "n")
                                    {
                                        Console.Write("Thanks For visiting...");
                                        passwordCheck = false;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Price For The Wraps is PKR599. ");
                                    Console.Write("Are You willing To buy?(Y/N): ");
                                    purchaseItem = Console.ReadLine();
                                    if (purchaseItem.ToLower() == "y")
                                    {
                                        Console.Write("Thanks For Buying The Item Your Bill is PKR599.");
                                    }
                                    else if (purchaseItem.ToLower() == "n")
                                    {
                                        Console.Write("Thanks For visiting...");
                                        passwordCheck = false;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Price For The Pasta is PKR299. ");
                                    Console.Write("Are You willing To buy?(Y/N): ");
                                    purchaseItem = Console.ReadLine();
                                    if (purchaseItem.ToLower() == "y")
                                    {
                                        Console.Write("Thanks For Buying The Item Your Bill is PKR299.");
                                    }
                                    else if (purchaseItem.ToLower() == "n")
                                    {
                                        Console.Write("Thanks For visiting...");
                                        passwordCheck = false;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Drink Menu\n--------\n1 - Coca Cola\n2 - String\n3 - Sprite");
                            Console.Write(">>");
                            selector = int.Parse(Console.ReadLine());
                            switch (selector)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Price For The Coca Cola is PKR30. ");
                                    Console.Write("Are You willing To buy?(Y/N): ");
                                    purchaseItem = Console.ReadLine();
                                    if (purchaseItem.ToLower() == "y")
                                    {
                                        Console.Write("Thanks For Buying The Item Your Bill is PKR30.");
                                    }
                                    else if (purchaseItem.ToLower() == "n")
                                    {
                                        Console.Write("Thanks For visiting...");
                                        passwordCheck = false;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Price For The String is PKR70. ");
                                    Console.Write("Are You willing To buy?(Y/N): ");
                                    purchaseItem = Console.ReadLine();
                                    if (purchaseItem.ToLower() == "y")
                                    {
                                        Console.Write("Thanks For Buying The Item Your Bill is PKR70.");
                                    }
                                    else if (purchaseItem.ToLower() == "n")
                                    {
                                        Console.Write("Thanks For visiting...");
                                        passwordCheck = false;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Price For The Pasta is PKR40. ");
                                    Console.Write("Are You willing To buy?(Y/N): ");
                                    purchaseItem = Console.ReadLine();
                                    if (purchaseItem.ToLower() == "y")
                                    {
                                        Console.Write("Thanks For Buying The Item Your Bill is PKR40.");
                                    }
                                    else if (purchaseItem.ToLower() == "n")
                                    {
                                        Console.Write("Thanks For visiting...");
                                        passwordCheck = false;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }
                            break;
                        case 3:
                            passwordCheck = false;
                            break;
                        default:
                            Console.Write("Invalid Input");
                            break;
                    }
                }
                Console.WriteLine("Chal Oye");
            }
            else
            {
                Console.Write("Username or Password is incorrect");
            }
            break;
        case 3:
            isContinue = false;
            Console.Write("Thanks For Using This...");
            break;
        default: Console.Write("Invalid Input"); break;
    }
    Console.ReadLine();
    Console.Clear();
}

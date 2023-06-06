namespace MartMenuWithSignupNLogin
{
    internal class Signup
    {
        private string fullname;
        private string username;
        private string email;
        private string password;
        public string FullName
        {
            get { return fullname; }
            set 
            {
                if(value != "")
                {
                    fullname = value;
                }
                else
                {
                    Console.WriteLine("Please Input Value");
                }
            }
        }
        public string UserName
        {
            get { return username; }
            set {
                if (value != "")
                {
                    username = value;
                }
                else
                {
                    Console.WriteLine("Please Input Value");
                }
            
            }
        }
        public string Email
        {
            get { return email; }
            set 
            {
                if (value != "")
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Please Input Value");
                }
            }
        }
        public string Password
        {
            get { return password; }
            set 
            {
                if (value != "")
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Please Input Value");
                }
            }
        }
        public bool CheckPassword(string userName, string password)
        {
            if (userName == UserName && password == Password)
            {
                return true;
            }
            return false;
        }

    }
}

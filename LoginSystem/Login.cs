namespace LoginSystem
{
    internal class Login
    {
        private string? userName, email, password;
        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public bool CheckUserName()
        {
            if(UserName == "fasih") 
            {
                return true;
            }
            return false;
        }
        public bool CheckUserEmail()
        {
            if (Email.ToLower() == "fasih@gmail.com")
            {
                return true;
            }
            return false;
        }
        public bool CheckUserPassword()
        {
            if (Password == "Fasih123")
            {
                return true;
            }
            return false;
        }
    }
}

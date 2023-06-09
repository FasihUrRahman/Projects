namespace AssignValueFromConstructor
{
    internal class Person
    {
        string name;
        int age;
        char gender;
        internal Person(string name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public char GetGender()
        {
            return gender;
        }
    }
}

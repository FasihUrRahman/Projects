namespace SoftwareToUnderStandClass
{
    internal class Student
{
        public int id;
        private string name;
        private int age;
        private int marks;
        private bool gender;
        private string className;
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public int GetMarks()
        {
            return marks;
        }
        public bool GetGender()
        {
            return gender;
        }
        public string GetClassName()
        {
            return className;
        }
        public void SetGender(bool value)
        {
            gender = value;
        }
}
}

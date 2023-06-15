namespace StudentInfoGetherWithMarks
{
    internal class Student
    {
        string stdName;
        int stdAge, stdClass, totalMarks = 0;
        int[] stdMarks;
        public void SetInfo(string stdName, int stdClass, int stdAge, int[] stdMarks)
        {
            this.stdName = stdName;
            this.stdAge = stdAge;
            this.stdMarks = stdMarks;
            Array.Copy(stdMarks, 0, this.stdMarks, 0, stdMarks.Length);
        }
        public void GetInfo()
        {
            int a = 1;
            Console.WriteLine($"Student Name: {stdName}\nStudent Age: {stdAge}\nStudent Class: {stdClass}\n--------------");
            foreach (int item in stdMarks)
            {
                totalMarks += item;
                Console.WriteLine($"Subject {a} Marks : {item}");
                a++;
            }
            Console.WriteLine($"Subjects Total Marks : {totalMarks}");
        }
    }
}

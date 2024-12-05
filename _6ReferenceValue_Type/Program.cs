// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    internal class Student
    {
        public string StudentName {get; set;}
    }
    internal class Program
    {
        static void ChangeReference(Student std2)
        {
            std2.StudentName = "Minh";
        }
        static void ChangeValue(int x)
        {
            x = 300;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            // int y = 200;
            // Console.WriteLine(y);
            // ChangeValue(y);
            // Console.WriteLine(y);

            Student std1 = new Student();
            std1.StudentName = "Duc";
            ChangeReference(std1);
            Console.WriteLine(std1.StudentName);
        }
    }
}
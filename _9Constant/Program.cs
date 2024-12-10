// See https://aka.ms/new-console-template for more information

namespace _9Constant
{
    internal class Program
    {
        //Const không cho phép thay đổi giá trị
        const int intValue = 15;
        const string stringValue = "Hello World";
        const Boolean check = true;
        
        public static void Main(string[] args)
        {
            Console.WriteLine(intValue);
            Console.WriteLine(stringValue);
            Console.WriteLine(check);
            
        }   
    }
}
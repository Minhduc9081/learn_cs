// See https://aka.ms/new-console-template for more information

using System.Numerics;

namespace _7BasicInputAndOuput
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Bài tập 1: In lời chào
            // Console.Write("Please enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine($"Xin chào, {name}");
            
            //Bài tập 2: Tính tổng hai số
            // Console.Write("Enter n1: ");
            // int n1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter n2: ");
            // int n2 = int.Parse(Console.ReadLine());
            // int sum = n1 + n2;
            // Console.WriteLine($"Sum of two number is: {sum}");
            
            //Bài tập 3: Kiểm tra tuổi
            // Console.Write("Enter your age: ");
            // int old = Int32.Parse(Console.ReadLine());
            // int age = DateTime.Now.Year - old;
            // Console.WriteLine($"You are {age} years old this year");
            
            //Bài tập 4: In bảng cửu chương
            // Console.Write("Enter the number: ");
            // int a = Int32.Parse(Console.ReadLine());
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine($"{a} x {i} = {a*i}");
            // }
            
            //Bài tập 5: Đoán ký tự
            // Console.Write("Enter any key: ");
            // var a = Console.ReadKey();
            // Console.WriteLine($"\nYou just pressed the key: {a.KeyChar}");
            
            //Bài tập 6: Hỏi thông tin cá nhân
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.Write("\nEnter your age: ");
            // int age = Int32.Parse(Console.ReadLine());
            // Console.Write("\nEnter Your address: ");
            // string addr = Console.ReadLine();
            //
            // Console.WriteLine($"Name: {name}, Age: {age}, Address: {addr}");
            
            //Bài tập 7: Tính chu vi và diện tích hình chữ nhật
            Console.Write("Enter length: ");
            float l = float.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            float w = float.Parse(Console.ReadLine());  
            
            Console.WriteLine($"S = {l*w}, P = {2*(l+w)}");
        }   
    }
}   
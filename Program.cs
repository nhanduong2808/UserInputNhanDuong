using System;

namespace UserInputNhanDuong
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_string;
            Console.WriteLine("Hi, this is Nhan Duong");
            Console.WriteLine("Please type anything then press Enter to show it!");
            input_string = Console.ReadLine();
            Console.WriteLine("Got it! You have typed: " + input_string);
        }
    }
}

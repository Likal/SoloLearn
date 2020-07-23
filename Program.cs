using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 88;
            switch (age) {
                case 16:
                    Console.WriteLine("Too young");
                    break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("The default case");
                    break;
            }
        }
    }
}
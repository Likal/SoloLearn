using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            if (age > 14) {
                if(age > 18) {
                    Console.WriteLine("Adult");
                }
                else {
                    Console.WriteLine("Teenager");
                }
            }
            else {
                if (age > 0) {
                    Console.WriteLine("Child");
                }
                else {
                    Console.WriteLine("Something's wrong");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{

    class Program
    {
        static void Main(string[] args)
        {
        
        do {
         Console.WriteLine("x = ");
         int x = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("y = ");
         int y = Convert.ToInt32(Console.ReadLine());

         int sum = x+y;
         Console.WriteLine("Result: {0}", sum);
        }
        while(true);
        }
    }
}
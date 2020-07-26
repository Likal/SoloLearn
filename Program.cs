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
            /*
            namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
while (x++ < 5)
{
    if (x % 2 == 0)
        x += 2;
}


        }
    }
}
*/

            int x = 1, loopCount = 0;
            Console.WriteLine("while loop");
            while (x++ < 5)
            {
                ++loopCount;
                Console.WriteLine(
                    $"Loop {loopCount}; x = {x}"
                );
                if (x % 2 == 0)
                {
                    x += 2;
                    Console.WriteLine(
                        $"Added 2 to x: {x}"
                    );
                }
            }
            Console.WriteLine(
                $"Program looped {loopCount} times"
            );
            Console.WriteLine(
                $"x = {x}"
            );
            
            x = 1;
            loopCount = 0;
            
            Console.WriteLine();
            Console.WriteLine("for loop");
            for ( ; x++ < 5; )
            {
                ++loopCount;
                Console.WriteLine(
                    $"Loop {loopCount}; x = {x}"
                );
                if (x % 2 == 0)
                {
                    x += 2;
                    Console.WriteLine(
                        $"Added 2 to x: {x}"
                    );
                }
            }
            Console.WriteLine(
                $"Program looped {loopCount} times"
            );
            Console.WriteLine(
                $"x = {x}"
            );
        }
    }
}
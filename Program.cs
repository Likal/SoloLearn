using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while(num < 6) 
            {
                Console.WriteLine(num);
                num+=2;
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
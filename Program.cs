﻿using System;
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
            int x = 10;
            for ( ; x > 0; x -= 3)
            {
                Console.WriteLine(x);
            }
        }
    }
}
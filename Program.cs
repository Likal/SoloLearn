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
         static int Sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            int res = Sum(11, 42);
            Console.WriteLine(res);
        }
    }
}
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
            for (int i = 0; i < 10; i++) {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
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
            for(int x=0; x<99; x++) {
                if(x%2 != 0)
                continue;

                Console.WriteLine(x);
            }
        }
    }
}
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
           /*int age = 42;
           string msg;
           if(age >= 18)
                msg = "Welcome";
           else 
                msg = "Sorry";

           Console.WriteLine(msg);*/

            // This replaces the above code, using the ?: operator
           int age = 42;
           string msg;
           msg = (age >= 18)? "Welcome" : "Sorry";
           Console.WriteLine(msg);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleTestJenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
﻿using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Geek g = new Geek();
            g.M1();
            g.M2();
            g.M3();
            g.M4();
            g.M5("Method Name: M5");
        }
    }
}

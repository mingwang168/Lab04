﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    public class Menu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            Console.WriteLine("1. Monkey\n2. Bear\n3. Quit\nSelection:");
        }
        public static void ShowMonkey()
        {
            Console.WriteLine("Species");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Squirrel\n2. Howler\n3. Colobus\nSelection:");
        }
        public static void ShowBear()
        {
            Console.WriteLine("Species");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Black\n2. Polar\nSelection:");
        }
    }
}
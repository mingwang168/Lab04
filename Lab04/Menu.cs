using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    public class Menu
    {
        public static int selectMainMenu;
        public static void ShowMainMenu()
        {
            Console.WriteLine("================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            Console.Write("1. Monkey\n2. Bear\n3. Quit\nSelection:");
            selectMainMenu = int.Parse(Console.ReadLine());
        }
        public static void ShowMonkey()
        {
            Console.WriteLine("Species");
            Console.WriteLine("----------------");
            Console.Write("1. Squirrel\n2. Howler\n3. Colobus\nSelection:");
        }
        public static void ShowBear()
        {
            Console.WriteLine("Species");
            Console.WriteLine("----------------");
            Console.Write("1. Black\n2. Polar\nSelection:");
        }
        public static void ShowWeight()
        {
            Console.Write("Weight in KG: ");
        }
        public static void ShowMealRecommendation()
        {
            Console.WriteLine("Meal Recommendation ");
            Console.WriteLine("================");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    public class Menu
    {
        public static int selectMainMenu = 0;
        public static string selectMainMenuInString = "";
        public static int selectMonkey = 0;
        public static string selectMonkeyInString = "";
        public static int selectBear = 0;
        public static string selectBearInString = "";
        public static void ShowMainMenu()
        {
            while (selectMainMenuInString != "1" && selectMainMenuInString != "2" && selectMainMenuInString != "3")
            {
                Console.WriteLine("================");
                Console.WriteLine("Zoo Menu Planner");
                Console.WriteLine("================");
                Console.Write("1. Monkey\n2. Bear\n3. Quit\nSelection:");
                selectMainMenuInString = Console.ReadLine();
                if (selectMainMenuInString != "3" && selectMainMenuInString != "1" && selectMainMenuInString != "2")
                {
                    Console.WriteLine("invalidate input!");
                }
            }
            selectMainMenu = int.Parse(selectMainMenuInString);
        }
        public static void ShowMonkey()
        {
            while (selectMonkeyInString != "1" && selectMonkeyInString != "2" && selectMonkeyInString != "3")
            {
                Console.WriteLine("Species");
                Console.WriteLine("----------------");
                Console.Write("1. Squirrel\n2. Howler\n3. Colobus\nSelection:");
                selectMonkeyInString = Console.ReadLine();
                if (selectMonkeyInString != "3" && selectMonkeyInString != "1" && selectMonkeyInString != "2")
                {
                    Console.WriteLine("invalidate input!");
                }
            }
            selectMonkey = int.Parse(selectMonkeyInString);
        }
        public static void ShowBear()
        {
            while (selectBearInString != "1" && selectBearInString != "2")
            {
                Console.WriteLine("Species");
                Console.WriteLine("----------------");
                Console.Write("1. Black\n2. Polar\nSelection:");
                selectBearInString = Console.ReadLine();
                if (selectBearInString != "1" && selectBearInString != "2")
                {
                    Console.WriteLine("invalidate input!");
                }
            }
            selectBear = int.Parse(selectBearInString);
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

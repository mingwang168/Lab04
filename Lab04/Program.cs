using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ShowMainMenu();
            var selectMainMenu= Console.ReadLine();
            while (selectMainMenu != "3")
            {
                if (selectMainMenu == "1")
                {
                    Menu.ShowMonkey();
                    var selectMonkey = Console.ReadLine();
                    Menu.ShowWeight();
                    var inputWeight = float.Parse(Console.ReadLine());
                    if (selectMonkey == "1")
                    {
                        Monkey myMonkey = new Monkey(inputWeight, "fresh fruit, vegetables, nuts, insects, berries", "9AM, 12PM and 5PM", inputWeight * 0.006f, 0.006f, "Squirrel");
                        myMonkey.ShowServing();
                        myMonkey.ShowInstruction();
                    }
                }
                else if(selectMainMenu == "2")
                {
                    Menu.ShowBear();
                    var selectBear = Console.ReadLine();
                }
            }
            Menu.ShowMainMenu();
        }
    }
}

using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] monkeyArray = new Monkey[3];
            monkeyArray[0]= new Monkey( 0.006f, "Squirrel");
            monkeyArray[1] = new Monkey( 0.007f, "Howler");
            monkeyArray[2] = new Monkey( 0.008f, "Colobus");
            Mammal[] bearArray = new Bear[2];
            bearArray[0] = new Bear(0.014f, "Black","berries, green vegetation, flowers, fruits, fish");
            bearArray[1] = new Bear( 0.016f, "Polar","berries, fish");

            Menu.ShowMainMenu();

            while (Menu.selectMainMenu != 3)
            {
                if (Menu.selectMainMenu == 1)
                {
                    Menu.ShowMonkey();
                    Menu.ShowWeight();
                    decimal cleanNum1 = 0;
                    var inputWightInString = Console.ReadLine();
                    while (!decimal.TryParse(inputWightInString, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an decimal value: ");
                        inputWightInString = Console.ReadLine();
                    }
                    var inputWeight = float.Parse(inputWightInString);
                    Menu.ShowMealRecommendation();
                    monkeyArray[Menu.selectMonkey - 1].PrintServing(inputWeight);
                    monkeyArray[Menu.selectMonkey - 1].ShowInstruction();
                }
                else if(Menu.selectMainMenu == 2)
                {
                    Menu.ShowBear();
                    Menu.ShowWeight();
                    decimal cleanNum1 = 0;
                    var inputWightInString = Console.ReadLine();
                    while (!decimal.TryParse(inputWightInString, out cleanNum1))
                    {
                        Console.Write("This is not valid input. Please enter an decimal value: ");
                        inputWightInString = Console.ReadLine();
                    }
                    var inputWeight = float.Parse(inputWightInString);
                    Menu.ShowMealRecommendation();
                    bearArray[Menu.selectBear - 1].PrintServing(inputWeight);
                    bearArray[Menu.selectBear - 1].ShowInstruction();
                }
                Menu.selectMainMenuInString = "";
                Menu.selectMonkeyInString = "";
                Menu.selectBearInString = "";
                Menu.ShowMainMenu();
            }

        }
    }
}

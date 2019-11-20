using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Monkey[] monkeyArray = new Monkey[3];
            monkeyArray[0]= new Monkey( 0.006f, "Squirrel");
            monkeyArray[1] = new Monkey( 0.007f, "Howler");
            monkeyArray[2] = new Monkey( 0.008f, "Colobus");
            Bear[] bearArray = new Bear[2];
            bearArray[0] = new Bear(0.014f, "Black","berries, green vegetation, flowers, fruits, fish");
            bearArray[1] = new Bear( 0.016f, "Polar","berries, fish");



            Menu.ShowMainMenu();

            while (Menu.selectMainMenu != 3)
            {

                if (Menu.selectMainMenu == 1)
                {
                    Menu.ShowMonkey();
                    var selectMonkey = int.Parse(Console.ReadLine());
                    Menu.ShowWeight();
                    var inputWeight = float.Parse(Console.ReadLine());
                    Menu.ShowMealRecommendation();
                    Console.WriteLine($"Mammal Type:  {monkeyArray[selectMonkey-1].type}");
                    Console.WriteLine($"Species:      {monkeyArray[selectMonkey - 1].Species}");
                    Console.WriteLine($"Weight:       {inputWeight}KG");
                    Console.WriteLine($"Serving:      {Math.Round(inputWeight * monkeyArray[selectMonkey - 1].ServingRatio, 3)}KG {monkeyArray[selectMonkey - 1].FoodPreference}");
                    monkeyArray[selectMonkey - 1].ShowInstruction();
                }
                else if(Menu.selectMainMenu == 2)
                {
                    Menu.ShowBear();
                    var selectBear = int.Parse(Console.ReadLine());
                    Menu.ShowWeight();
                    var inputWeight = float.Parse(Console.ReadLine());
                    Menu.ShowMealRecommendation();
                    Console.WriteLine($"Mammal Type:  {bearArray[selectBear - 1].type}");
                    Console.WriteLine($"Species:      {bearArray[selectBear - 1].Species}");
                    Console.WriteLine($"Weight:       {inputWeight}KG");
                    Console.WriteLine($"Serving:      {Math.Round(inputWeight * bearArray[selectBear - 1].ServingRatio,3)}KG {bearArray[selectBear - 1].FoodPreference}");
                    monkeyArray[selectBear - 1].ShowInstruction();
                }
                Menu.ShowMainMenu();
            }

        }
    }
}

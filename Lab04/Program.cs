using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Monkey[] monkeyArray = new Monkey[3];
            monkeyArray[0]= new Monkey("fresh fruit, vegetables, nuts, insects, berries", "9AM, 12PM and 5PM", 0.006f, "Squirrel");
            monkeyArray[1] = new Monkey("fresh fruit, vegetables, nuts, insects, berries", "9AM, 12PM and 5PM", 0.007f, "Howler");
            monkeyArray[2] = new Monkey("fresh fruit, vegetables, nuts, insects, berries", "9AM, 12PM and 5PM", 0.008f, "Colobus");
            Bear[] bearArray = new Bear[2];
            bearArray[0] = new Bear("berries, green vegetation, flowers, fruits, fish", "9AM and 3PM", 0.014f, "Black");
            bearArray[1] = new Bear("berries, fish", "9AM, 12PM and 5PM", 0.016f, "Polar");



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
                    Console.WriteLine($"Species:  {monkeyArray[selectMonkey - 1].Species}");
                    Console.WriteLine($"Weight:   {inputWeight}KG");
                    Console.WriteLine($"Serving:  {Math.Round(inputWeight * monkeyArray[selectMonkey - 1].ServingRatio, 3)}KG {monkeyArray[selectMonkey - 1].FoodPreference}");
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
                    Console.WriteLine($"Species:                 {bearArray[selectBear - 1].Species}");
                    Console.WriteLine($"Weight:                  {inputWeight}KG");
                    Console.WriteLine($"Serving:                 {Math.Round(inputWeight * bearArray[selectBear - 1].ServingRatio,3)}KG {bearArray[selectBear - 1].FoodPreference}");
                    monkeyArray[selectBear - 1].ShowInstruction();
                }
                Menu.ShowMainMenu();
            }

        }
    }
}

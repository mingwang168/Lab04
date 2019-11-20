using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    public abstract class Mammal
    {
        protected string FoodPreference { get; set; }
        protected string FeedTime { get; set; }
        protected float ServingRatio { get; set; }
        protected string Species { get; set; }
        protected string Type { get; set; }
        protected Mammal(float ServingRatio,string Species)
        {
            this.Species = Species;
            this.ServingRatio = ServingRatio;
        }
        public void PrintDetail(float inputWeight)
        {
            Console.WriteLine($"Mammal Type:  {Type}");
            Console.WriteLine($"Species:      {Species}");
            Console.WriteLine($"Weight:       {inputWeight}KG");
            Console.WriteLine($"Serving:      {Math.Round(inputWeight * ServingRatio, 3)}KG {FoodPreference}");
            Console.WriteLine("Instructions: Keep area secure at all times.");
            Console.WriteLine($"              Feed at {FeedTime}");
        }
    }
}

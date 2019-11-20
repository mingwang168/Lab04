using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    public abstract class Mammal
    {
        public  string FoodPreference { get; set; }
        public  string FeedTime { get; set; }
        public float ServingRatio { get; set; }
        public string Species { get; set; }

        public Mammal(float ServingRatio,string Species)
        {
            this.Species = Species;
            this.ServingRatio = ServingRatio;
        }
        public  void ShowInstruction()
        {
            Console.WriteLine("Instructions: Keep area secure at all times.");
            Console.WriteLine($"              Feed at {FeedTime}");
        }


    }
}

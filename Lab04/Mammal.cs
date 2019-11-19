using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    public abstract class Mammal
    {
        public  float Weight { get; set; }
        public  string FoodPreference { get; set; }
        public  string FeedTime { get; set; }
        public  float FoodIntake { get; set; }

        public float ServingRatio { get; set; }
        public string Species { get; set; }
        public Mammal(float Weight, string FoodPreference,string FeedTime,float FoodIntake, float ServingRatio, string Species)
        {
            this.Weight = Weight;
            this.FoodPreference = FoodPreference;
            this.FeedTime = FeedTime;
            this.FoodIntake = FoodIntake;
            this.ServingRatio = ServingRatio;
            this.Species = Species;
        }
        public  void ShowInstruction()
        {
            Console.WriteLine("Keep area secure at all times.");
            Console.WriteLine($"Feed at {FeedTime}");
        }

        public  void ShowServing()
        {
            FoodIntake = Weight * ServingRatio;
            Console.WriteLine($"Serving:{FoodIntake} KG {FoodPreference}");
        }
    }
}

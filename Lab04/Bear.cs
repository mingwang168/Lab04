using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Bear : Mammal
    {
        public string type { get; set; }
        public string Species { get; set; }
        public Bear(float Weight, string FoodPreference, string FeedTime, float FoodIntake, float ServingRatio,string Species) : base(Weight, FoodPreference, FeedTime, FoodIntake, ServingRatio)
        {
            type = "bear";
            this.Species = Species;
        }
        

    }
}

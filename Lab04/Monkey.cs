using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Monkey : Mammal
    {
        public string type { get; set; }
        public string Species { get; set; }
        public Monkey(float Weight, string FoodPreference, string FeedTime, float FoodIntake, float ServingRatio, string Species) : base(Weight, FoodPreference, FeedTime, FoodIntake, ServingRatio)
        {
            this.type = "monkey";
            this.Species = Species;
        }

        public override void ShowServing()
        {

        }
    }
}

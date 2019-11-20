using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Bear : Mammal
    {
        public Bear(float ServingRatio,string Species,string FoodPreference) : base(ServingRatio, Species)
        {
            this.FoodPreference = FoodPreference;
            Type = "bear";
            FeedTime = "9AM and 3PM";
        }
        

    }
}

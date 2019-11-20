using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Bear : Mammal
    {
        public string type { get; set; }
        public string Species { get; set; }
        public Bear(string FoodPreference, string FeedTime, float ServingRatio,string Species) : base(FoodPreference, FeedTime,  ServingRatio)
        {
            type = "bear";
            this.Species = Species;
        }
        

    }
}

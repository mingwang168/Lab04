using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Monkey : Mammal
    {
        public string type { get; set; }
        public string Species { get; set; }
        public Monkey(string FoodPreference, string FeedTime, float ServingRatio, string Species) : base(FoodPreference, FeedTime, ServingRatio)
        {
            this.type = "monkey";
            this.Species = Species;
        }


    }
}

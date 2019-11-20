using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Bear : Mammal
    {
        public string type { get; set; }
        public string Species { get; set; }
        public Bear(float ServingRatio,string Species,string FoodPreference) : base(ServingRatio, Species)
        {
            this.FoodPreference = FoodPreference;
            type = "bear";
            this.Species = Species;
        }
        

    }
}

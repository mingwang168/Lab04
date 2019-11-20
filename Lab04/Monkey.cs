using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Monkey : Mammal
    {
        public string type { get; set; }
        public string Species { get; set; }
        public Monkey(float ServingRatio, string Species) : base(ServingRatio, Species)
        {
            FoodPreference = "fresh fruit, vegetables, nuts, insects, berries";
            FeedTime = "9AM, 12PM and 5PM";
            type = "monkey";
            this.Species = Species;
        }
    }
}

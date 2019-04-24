using System;

namespace PimpedRose
{
    
        public class DatabaseItem
        {
            public string Name { get; set; }
            public string SellIn { get; set; }
            public string Quality { get; set; }


            public DatabaseItem(String name, String sellIn, String quality)
            {
                this.Name = name;
                this.SellIn = sellIn;
                this.Quality = quality;
            }
        
    }
}

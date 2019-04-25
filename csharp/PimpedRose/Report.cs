using System;
using System.Collections.Generic;
using System.Linq;

namespace PimpedRose
{

    public class Report
    {
        List<Item> items;
        PricingRegistry pricingRegistry = new PricingRegistry();

        public Report(List<Item> items)
        {
            this.items = items;
        }


        public override string ToString()
        {
            var headerFormat = "{0,-20} {1,10} {2,10} {3,10}";
            var format = "{0,-20} {1,10} {2,10} {3,10:C}";
            var header = string.Format(
                headerFormat,
                "name",
                "quality",
                "sell in",
                "price"
            );
            var table = items.Select(i=>string.Format(
                    format,
                    i.Name,
                    i.Quality,
                    i.SellIn,
                    pricingRegistry.getPrice(i)
                ));
            return header + "\n" + string.Join("\n", table);
        }
    }
}

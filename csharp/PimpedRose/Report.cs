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


        public string toString()
        {
            var headerFormat = "%-20s %10s %10s %10s";
            var format = "%-20s %10s %10s %10.2f";
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

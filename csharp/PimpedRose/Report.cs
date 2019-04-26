using System;
using System.Collections.Generic;
using System.Linq;

namespace PimpedRose
{

    public class Report
    {
        List<Item> _items;
        PricingRegistry _pricingRegistry = new PricingRegistry();

        public Report(List<Item> items)
        {
            this._items = items;
        }


        public override string ToString()
        {
            var headerFormat = "{0,-20} {1,10} {2,10} {3,10}";
            var format = "{0,-20} {1,10} {2,10} {3,10:C}";
            var header = String.Format(
                headerFormat,
                "name",
                "quality",
                "sell in",
                "price"
            );
            var table = _items.Select(i=>String.Format(
                    format,
                    i.Name,
                    i.Quality,
                    i.SellIn,
                    _pricingRegistry.GetPrice(i)
                ));
            return header + "\n" + String.Join("\n", table);
        }

        public static Report createReport(List<Item> x)
        {
            return new Report(x);
        }
    }
}

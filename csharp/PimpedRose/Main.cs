using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PimpedRose
{

    public static class Program
    {
        public static async Task<int> Main()
        {
            (await Database.GetItems())
                .Select(HandleDatabaseResult)
                .Select(UpdateItems)
                .Select(x => new Report(x))
                .ToList()
                .ForEach(WriteReport);

            return 0;
        }

        private static List<Item> HandleDatabaseResult(DatabaseResult r)
        {
            return r.Result.Select(i => new Item
            {
                Name = i.Name,
                SellIn = Convert.ToInt32(i.SellIn),
                Quality = Convert.ToInt32(i.Quality)
            }).ToList();
        }

        private static List<Item> UpdateItems(List<Item> items)
        {
            GildedRose gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();
            return items;
        }

        private static void WriteReport(Report report)
        {
            try
            {
                var filename = "report.txt";
                using (var outputFile = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), filename)))
                {
                    outputFile.Write(report.toString());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

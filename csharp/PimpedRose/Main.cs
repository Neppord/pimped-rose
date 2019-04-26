using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;

namespace PimpedRose
{

    public static class Program
    {
        public static void Main()
        {
            Database.GetItems()
                .Select(HandleDatabaseResult)
                .Select(GildedRose.UpdateItems)
                .Select(Report.createReport)
                .Subscribe(WriteReport);
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

        private static void WriteReport(Report report)
        {
            try
            {
                const string filename = "report.txt";
                using (var outputFile = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), filename)))
                {
                    outputFile.Write(report.ToString());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

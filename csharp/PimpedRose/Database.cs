using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PimpedRose;

namespace PimpedRose
{

    public class Database
    {
        public static async Task<List<DatabaseResult>> GetItems()
        {
            var result = new DatabaseResult(
                new DateTime(),
                new List<DatabaseItem>
                {
                    new DatabaseItem("Helmet", "1", "1"),
                    new DatabaseItem("Shield", "1", "1")

                }
            );
            await Task.Delay(100);
            return new List<DatabaseResult>{result};
        }
    }

}

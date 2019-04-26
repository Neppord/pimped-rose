using System;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace PimpedRose
{

    public class Database
    {
        public static IObservable<DatabaseResult> GetItems()
        {
            var result = new DatabaseResult(
                new DateTime(),
                new List<DatabaseItem>
                {
                    new DatabaseItem("Helmet", "1", "1"),
                    new DatabaseItem("Shield", "1", "1")

                }
            );
            return Observable.Return(result);
        }
    }

}

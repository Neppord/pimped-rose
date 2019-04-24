using System;
using System.Collections.Generic;

namespace PimpedRose
{
    public class DatabaseResult
    {
        public DateTime Timestamp { get; }
        public List<DatabaseItem> Result { get; }

        public DatabaseResult(DateTime timestamp, List<DatabaseItem> result)
        {
            this.Timestamp = timestamp;
            this.Result = result;
        }
    }
}

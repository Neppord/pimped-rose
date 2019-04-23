package codingdojo;


import java.util.Date;
import java.util.List;

public class DatabaseResult {
    final Date timestamp;
    final List<DatabaseItem> result;

    public DatabaseResult(Date timestamp, List<DatabaseItem> result) {
        this.timestamp = timestamp;
        this.result = result;
    }

    static class DatabaseItem {
        public String name;

        public String sellIn;

        public String quality;

        public DatabaseItem(String name, String sellIn, String quality) {
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
        }
    }
}

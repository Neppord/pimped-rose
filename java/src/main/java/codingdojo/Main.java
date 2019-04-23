package codingdojo;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.OpenOption;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] argv) {
        Database
            .getItems()
            .map(r -> r.result.stream()
                .map(i -> new Item(
                    i.name,
                    Integer.valueOf(i.sellIn),
                    Integer.valueOf(i.quality)
                )).collect(Collectors.toList()).toArray(new Item[]{})
            ).map(Main::updateItems)
            .map(Arrays::asList)
            .map(Report::new)
            .subscribe(report -> {
                try {
                    String filename = "report.txt";
                    Path path = Paths.get(filename);
                    String reportString = report.toString();
                    Files.write(path, reportString.getBytes());
                } catch (IOException e) {
                    e.printStackTrace();
                }
            });
    }

    private static Item[] updateItems(Item[] items) {
        GildedRose gildedRose = new GildedRose(items);
        gildedRose.updateQuality();
        return items;
    }
}

package codingdojo;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.text.SimpleDateFormat;
import java.util.List;
import java.util.stream.Collectors;

public class Main {
    static SimpleDateFormat simpleDateFormatter =
        new SimpleDateFormat("yyyy-MM-dd_hh-mm-ss");
    public static void main(String[] argv) {
        Database.getItems()
            .map(Main::handleDatabaseResult)
            .map(GildedRose::updateItems)
            .map(Report::createReport)
            .subscribe(Main::writeReport);
    }

    private static List<Item> handleDatabaseResult(DatabaseResult r) {
        return r.result.stream()
            .map(i -> new Item(
                i.name,
                Integer.valueOf(i.sellIn),
                Integer.valueOf(i.quality)
            )).collect(Collectors.toList());
    }

    private static void writeReport(Report report) {
        try {
            String filename = "report.txt";
            Path path = Paths.get(filename);
            String reportString = report.toString();
            Files.write(path, reportString.getBytes());
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

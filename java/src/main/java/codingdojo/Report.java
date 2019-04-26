package codingdojo;

import java.util.List;
import java.util.stream.Collectors;

public class Report {
    final List<Item> items;
    final PricingRegistry pricingRegistry = new PricingRegistry();

    private Report(List<Item> items) {
        this.items = items;
    }

    public static Report createReport(List<Item> items) {
        return new Report(items);
    }

    @Override
    public String toString() {
        String headerFormat = "%-20s %10s %10s %10s";
        String format = "%-20s %10s %10s %10.2f";
        String header = String.format(
            headerFormat,
            "name",
            "quality",
            "sell in",
            "price"
        );
        String table = items.stream()
            .map(i -> String.format(
                format,
                i.name,
                i.quality,
                i.sellIn,
                pricingRegistry.getPrice(i)
                ))
            .collect(Collectors.joining("\n"));
        return header + "\n" + table;
    }
}

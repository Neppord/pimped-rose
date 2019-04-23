package codingdojo;

import codingdojo.DatabaseResult.DatabaseItem;
import reactor.core.publisher.Mono;

import java.util.Arrays;
import java.util.Date;


public class Database {
    public static Mono<DatabaseResult> getItems() {
        return Mono.create(sink -> {
            sink.success(new DatabaseResult(
                new Date(),
                Arrays.asList(
                    new DatabaseItem("Helmet", "1", "1"),
                    new DatabaseItem("Shield", "1", "1")
                )
            ));
        });
    }
}

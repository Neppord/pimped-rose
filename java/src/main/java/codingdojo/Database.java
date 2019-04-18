package codingdojo;

import reactor.core.publisher.Mono;

import java.util.List;

public class Database {
    public static Mono<List<Item>> getItems() {
        return Mono.empty();
    }
}

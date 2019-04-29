package codingdojo;

import java.util.function.Function;

public class Id<T> {
    public final T value;

    public Id(T value) {
        this.value = value;
    }

    public <R> Id<R> map(Function<T, R> function) {
        return null;
    }
}

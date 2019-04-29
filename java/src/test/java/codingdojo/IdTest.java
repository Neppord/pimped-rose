package codingdojo;

import org.junit.Test;

import java.util.function.Function;

import static org.junit.Assert.*;

public class IdTest {


    private final Function<String, Integer> length = String::length;
    private final Function<Integer, String> toString = Object::toString;

    @Test
    public void testCompositionLawPostComposition() {
        Id<String> stringId = new Id<>("");

        String value = stringId.map(length).map(toString).value;

        assertEquals("0", value);
    }

    @Test
    public void testCompositionLawPreComposition() {
        Id<String> stringId = new Id<>("");

        String value = stringId.map(length.andThen(toString)).value;

        assertEquals("0", value);
    }
}
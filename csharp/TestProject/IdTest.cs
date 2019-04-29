using Xunit;

namespace PimpedRose
{
    public class IdTest
    {
        [Fact]
        public void testCompositionLawPostComposition()
        {
            var stringId = new Id<string>("");

            string value = stringId
                .Select(x => x.Length)
                .Select(x => x.ToString())
                .Value;

            Assert.Equal("0", value);
        }

        [Fact]
        public void testCompositionLawPreComposition()
        {
            var stringId = new Id<string>("");

            string value = stringId
                .Select(x => x.Length.ToString())
                .Value;

            Assert.Equal("0", value);
        }
    }
}
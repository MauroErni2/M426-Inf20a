using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_Test6()
        {
            string expected = "Foo";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.Determine(6);


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_Test21()
        {
            string expected = "FooQix";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.Determine(21);


            Assert.Equal(expected, actual);
        }  

        [Fact]
        public void Determine_Test13()
        {
            string expected = "13";
            FooBarQixDeterminer determiner = new FooBarQixDeterminer();

            string actual = determiner.Determine(13);


            Assert.Equal(expected, actual);
        }
    }
}
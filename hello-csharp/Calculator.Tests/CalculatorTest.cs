using System;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FivePlusThreeIsEight()
        {
            Assert.Equal(8, Calculator.Add(3, 5));
        }

        [Fact]
        public void TestAddThreeToTwoIsFive()
        {
            Assert.Equal(5, Calculator.Add(3, 2));
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            Assert.Equal(2, Calculator.Substract(6, 4));
        }

        [Fact]
        public void TestMultiplyFourAndTwoIsEight()
        {
            Assert.Equal(8, Calculator.Multiply(4, 2));
        }

        [Fact]
        public void TestDivideWithZero()
        {
            Assert.Throws<ArgumentException>(() => Assert.Equal(0, Calculator.divide(6, 0));
        }
    }
}

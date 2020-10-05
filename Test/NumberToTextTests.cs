using System;
using Domain;
using Xunit;

namespace Test
{
    public class NumberToTextTests
    {
        [Fact]
        public void CanHandleSingleDigit()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("9");
            var expected = "nine";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleNegativeDigit()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("-1");
            var expected = "negative one";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleSpecialDoubleDigits()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("14");
            var expected = "fourteen";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleDoubleDigits()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("42");
            var expected = "forty two";

            // assert
            Assert.Equal(expected, actual);
        }

    }
}

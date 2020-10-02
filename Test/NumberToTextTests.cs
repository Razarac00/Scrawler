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

    }
}

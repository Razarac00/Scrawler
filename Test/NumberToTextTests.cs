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
        public void CanHandleQuestionableZero()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("+0");
            var expected = "positive zero";

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

        [Fact]
        public void CanHandleTripleDigits()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("343");
            var expected = "three hundred forty three";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleNegativeTripleDigits()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("-717");
            var expected = "negative seven hundred seventeen";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleZeroesTripleDigits()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("600");
            var expected = "six hundred";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleThousands()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("6001");
            var expected = "six thousand one";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleThousandsWithComma()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("1,337");
            var expected = "one thousand three hundred thirty seven";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleBigThousands()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("696,969");
            var expected = "six hundred ninety six thousand nine hundred sixty nine";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleMillions()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("12,696,969");
            var expected = "twelve million six hundred ninety six thousand nine hundred sixty nine";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleBillionsInDebt()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("-88,312,696,969");
            var expected = "negative eighty eight billion three hundred twelve million six hundred ninety six thousand nine hundred sixty nine";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanHandleEVENTrillions()
        {
            // arrange
            string actual;
            var test = new NumberToText();

            // act
            actual = test.Convert("1,000,000,000,000");
            var expected = "one trillion";

            // assert
            Assert.Equal(expected, actual);
        }

    }
}

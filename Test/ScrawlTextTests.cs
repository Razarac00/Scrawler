using System;
using App;
using Xunit;

namespace Test
{
    public class ScrawlTextTests
    {
        [Fact]
        public void OriginalStringHasDefault()
        {
            // arrange
            string actual;
            var test = new ScrawlText();

            // act
            actual = test.OriginalString;
            var expected = "";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RebuiltStringHasDefault()
        {
            // arrange
            string actual;
            var test = new ScrawlText();

            // act
            actual = test.RebuiltString;
            var expected = "";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RebuiltStringHandlesDigits()
        {
            // arrange
            string actual;
            var test = new ScrawlText();

            // act
            test.OriginalString = "13";
            actual = test.RebuiltString;
            var expected = "thirteen";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RebuiltStringHandlesWords()
        {
            // arrange
            string actual;
            var test = new ScrawlText();

            // act
            test.OriginalString = "try me";
            actual = test.RebuiltString;
            var expected = "try me";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RebuiltStringHandlesWordsDigits()
        {
            // arrange
            string actual;
            var test = new ScrawlText();

            // act
            test.OriginalString = "3 strikes and you out";
            actual = test.RebuiltString;
            var expected = "three strikes and you out";

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RebuiltStringHandlesCommaDigits()
        {
            // arrange
            string actual;
            var test = new ScrawlText();

            // act
            test.OriginalString = "3,123,000";
            actual = test.RebuiltString;
            var expected = "three million one hundred twenty three thousand";

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
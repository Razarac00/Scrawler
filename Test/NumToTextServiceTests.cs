using System;
using App;
using App.Controllers;
using Xunit;

namespace Test
{
    public class NumToTextServiceTests
    {
        [Fact]
        public void GetReturnsEmptyScrawlText()
        {
        // Arrange
        var test = new NumToTextServiceController();
        
        // Act
        var actual = test.Get();
        var expected = "";
        
        // Assert
        Assert.IsType<ScrawlText>(actual);
        Assert.Equal(expected, actual.OriginalString);
        Assert.Equal(expected, actual.RebuiltString);
        }

        [Fact]
        public void PostReturnsUpdatedST()
        {
        // Arrange
        var test = new NumToTextServiceController();
        var forminput = new ScrawlText();
        forminput.OriginalString = "2";
        
        // Act
        var actual = test.Post(forminput);
        var expected1 = "2";
        var expected2 = "two";
        
        // Assert
        Assert.IsType<ScrawlText>(actual);
        Assert.Equal(expected1, actual.OriginalString);
        Assert.Equal(expected2, actual.RebuiltString);
        }
    }
}
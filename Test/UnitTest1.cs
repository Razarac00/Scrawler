using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2,2));
        }

        int Add(int x, int y) { return x + y; }
    }
}

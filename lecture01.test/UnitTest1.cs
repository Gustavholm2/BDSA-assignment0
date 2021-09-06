using System;
using Xunit;

namespace lecture01.test
{
    public class UnitTest1
    {
        [Fact]
        public void divisible_by_four()
        {
            Assert.True(Program.IsLeapYear(16));
        }
    }
}

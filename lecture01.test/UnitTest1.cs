using System;
using Xunit;

namespace lecture01.test
{
    public class UnitTest1
    {
        [Fact]
        public void not_leap_year() 
        {
            Assert.False(Program.IsLeapYear(5));
        }

        [Fact]
        public void divisible_by_four()
        {
            Assert.True(Program.IsLeapYear(16));
        }

        [Fact]
        public void divisible_by_one_hundred() 
        {
            Assert.False(Program.IsLeapYear(1900));
        }

        [Fact]
        public void divisible_by_four_hundred() 
        {
            Assert.True(Program.IsLeapYear(2000));
        }
    }
}

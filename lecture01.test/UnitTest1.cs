using System;
using System.IO;
using Xunit;

namespace lecture01.test
{
    public class IsLeapYearTest
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

    public class MainTest
    {
        [Fact]
        public void Yay()
        {
        //Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        Console.SetIn(new StringReader("2020"));
        Program.Main(new String[0]);
        var output = writer.GetStringBuilder().ToString().Trim()[^3..^0];
        
        //Assert
        Assert.Equal("yay", output);

        }

        [Fact]
        public void Nay()
        {
        //Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);
        
        //Act
        Console.SetIn(new StringReader("2021"));
        Program.Main(new String[0]);
        var output = writer.GetStringBuilder().ToString().Trim()[^3..^0];
        
        //Assert
        Assert.Equal("nay", output);
        }
    }

}

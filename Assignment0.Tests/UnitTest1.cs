using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void isLeapYear_2020_is_LeapYear()
        {
            //Arrange
            var input = 2020;

            //Act
            var output = Program.isLeapYear(input);
            
            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void isLeapYear_2021_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = 2021;

            //Act
            var output = Program.isLeapYear(input);
            
            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void isLeapYear_1900_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = 1900;

            //Act
            var output = Program.isLeapYear(input);
            
            //Assert
            Assert.Equal(false, output);
        }

        [Fact]  
        public void isLeapYear_1600_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = 1600;

            //Act
            var output = Program.isLeapYear(input);
            
            //Assert
            Assert.Equal(true, output);
        }
        [Fact]
        public void Main_2020_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2020");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);
            
            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Main_2021_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2021");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Main_1900_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1900");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }

        [Fact]  
        public void Main_1600_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1600");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

                [Fact]  
        public void Main_1581_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1581");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Must be above 1581", output);
        }

        [Fact]  
        public void Main_hello_is_LeapYear()
        {
            //Arrange
            var writer = new StringWriter(); //opretter en writer
            Console.SetOut(writer);  //sender console out til writeren

            var input = new StringReader("hello"); //laver input med stringreader
            Console.SetIn(input); //bruger stringreader som input

            //Act
            Program.Main(new string[0]); //starter programmet

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim(); //får fat i consolens outputt og trimmer det
            Assert.Equal("Please write a number", output); //asserter forventet vs. egentlige resultat
        }
    }
}

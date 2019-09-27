using Xunit;
using System;

namespace CSharp_Calculator
{
    public class Csharp_Calculator_Custom_Test
    {
              [Fact]
        public void Add_Custom_Delimiter_Test(){

            int expected = 25;

            int actual = Program.Custom_Delimiter("20,5");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Invalid_Numbers(){

            int expected = 20;

            int actual = Program.Custom_Delimiter("20,abcde");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Invalid_Numbers_Missing_Numbers(){

            int expected = 20;

            int actual = Program.Custom_Delimiter("20,,abcde");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_New_Line(){

            int expected = 50;

            int actual = Program.Custom_Delimiter("20\n20,10");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_With_Missing_Numbers(){

            int expected = 20;

            int actual = Program.Custom_Delimiter("20");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Numbers_Greater_Than_OneThousand(){

            int expected = 30;

            int actual = Program.Custom_Delimiter("20,1001,10");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Numbers_Negative_Numbers(){

            
            Action act = () => Program.Custom_Delimiter("20,1001,-10");
            Assert.Throws<ArgumentException>(act);
        }
    }
}
using Xunit;
using System;


namespace CSharp_Calculator
{
    public class Csharp_Calculator_Test
    {
          [Fact]
        public void Add_Simple_Comma_Delimiter_Test(){

            int expected = 25;

            int actual = Program.Simple_Comma_Delimiter("20,5");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_Invalid_Numbers(){

            int expected = 20;

            int actual = Program.Simple_Comma_Delimiter("20,abcde");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_New_Line(){

            int expected = 50;

            int actual = Program.Simple_Comma_Delimiter("20\n20,10");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_With_Missing_Numbers(){

            int expected = 20;

            int actual = Program.Simple_Comma_Delimiter("20");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_Numbers_Greater_Than_OneThousand(){

            int expected = 30;

            int actual = Program.Simple_Comma_Delimiter("20,1001,10");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_Numbers_Negative_Numbers(){

            
            Action act = () => Program.Simple_Comma_Delimiter("20,1001,-10");
            Assert.Throws<ArgumentException>(act);
        }
    }
}
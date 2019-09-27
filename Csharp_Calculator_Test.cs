using Xunit;
namespace CSharp_Calculator
{
    public class Csharp_Calculator_Test
    {
          [Fact]
        public void Add_Simple_Comma_Delimiter_Test(){

            int expected = 25;

            int actual = Program.SimpleCommaDelimiter("20,5");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_Invalid_Numbers(){

            int expected = 20;

            int actual = Program.SimpleCommaDelimiter("20,abcde");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_New_Line(){

            int expected = 50;

            int actual = Program.SimpleCommaDelimiter("20\n20,10");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_With_Missing_Numbers(){

            int expected = 20;

            int actual = Program.SimpleCommaDelimiter("20");

            Assert.Equal(expected,actual);

        }
        [Fact]
        public void Add_Simple_Comma_Delimiter_Test_Numbers_Greater_Than_OneThousand(){

            int expected = 30;

            int actual = Program.SimpleCommaDelimiter("20,1001,10");

            Assert.Equal(expected,actual);

        }
        // [Fact]
        // public void Add_Simple_Comma_Delimiter_Test_Numbers_Negative_Numbers(){

            
        //     var exception = Assert.Throws<InvalidOperationException>(() => Program.SimpleCommaDelimiter("20,1001,-10"));

        //     Assert.Equal("Could not calculate due to negative number",exception);

        // }
    }
}
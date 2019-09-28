using Xunit;
using System;
namespace CSharp_Calculator
{
    public class Csharp_Calculator_Custom_Test
    {

        [Fact]
        public void Add_Custom_Delimiter_Split_One_Value()
        {


            string[] expected = { "***", "\n" };

            string[] actual = Utility.Custom_Delimiter_Value("[***]\n11***22***33");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Custom_Delimiter_Number_String()
        {


            string expected = "11***22***33";

            string actual = Utility.Custom_Delimiter_Number_String_value("[***]\n11***22***33");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Custom_Delimiter_Split_Multi_Values()
        {


            string[] expected = { "*", "!!", "r9r", "\n" };


            string[] actual = Utility.Custom_Delimiter_Value("[*][!!][r9r]\n11r9r22*33!!44");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Custom_Delimiter_Test()
        {

            int expected = 66;

            int actual = Program.Custom_Delimiter("//[***]\n11***22***33");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Invalid_Numbers()
        {

            int expected = 44;

            int actual = Program.Custom_Delimiter("//[***]\n11***ascf***33");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Invalid_Numbers_Missing_Numbers()
        {

            int expected = 11;

            int actual = Program.Custom_Delimiter("//[***]\n11*** ***abcd");

            Assert.Equal(expected, actual);

        }
        // [Fact]
        // public void Add_Custom_Delimiter_Test_New_Line()
        // {

        //     int expected = 50;

        //     int actual = Program.Custom_Delimiter("20\n20,10");

        //     Assert.Equal(expected, actual);

        // }
        [Fact]
        public void Add_Custom_Delimiter_Test_With_Missing_Numbers()
        {

            int expected = 11;

            int actual = Program.Custom_Delimiter("//[***]\n11");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Numbers_Greater_Than_OneThousand()
        {

            int expected = 44;

            int actual = Program.Custom_Delimiter("//[***]\n11***1001***33");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Delimiter_Test_Numbers_Negative_Numbers()
        {


            Action act = () => Program.Custom_Delimiter("//[***]\n11***22***-33");
            Assert.Throws<ArgumentException>(act);
        }
    }
}
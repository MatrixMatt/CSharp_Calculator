using Xunit;
using System;
namespace CSharp_Calculator
{
    public class Csharp_Calculator_Custom_Test
    {
        [Fact]
        public void Add_Custom_Delimiter_Split_One_Value_Single_Character()
        {


            char[] expected = { '*', '\n' };

            char[] actual = Utility.Custom_Delimiter_Single_Character_Value("*\n11***22***33");

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Add_Custom_Delimiter_Split_One_Value_Multi_Character()
        {


            char[] expected = { '*', '\n' };

            char[] actual = Utility.Custom_Delimiter_Single_Character_Value("**\n11***22***33");

            Assert.Equal(expected, actual);
        }
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


            string expected = "11***22***33\n11";

            string actual = Utility.Custom_Delimiter_Number_String_value("[***]\n11***22***33\n11");

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

        [Fact]
        public void Add_Custom_Delimiter_Test_New_Line()
        {

            int expected = 54;

            int actual = Program.Custom_Delimiter("//[***]\n11***ascf***33\n10");

            Assert.Equal(expected, actual);

        }
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
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test()
        {

            int expected = 110;

            int actual = Program.Custom_Delimiter("//[*][!!][r9r]\n11r9r22*33!!44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test_Invalid_Numbers()
        {

            int expected = 77;

            int actual = Program.Custom_Delimiter("//[*][!!][r9r]\n11r9r22*abcd!!44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test_Invalid_Numbers_Missing_Numbers()
        {

            int expected = 77;

            int actual = Program.Custom_Delimiter("//[*][!!][r9r]\n11r9r22*!!44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test_New_Line()
        {

            int expected = 120;

            int actual = Program.Custom_Delimiter("//[*][!!][r9r]\n11r9r22*33!!44\n10");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test_With_Missing_Numbers()
        {

            int expected = 11;

            int actual = Program.Custom_Delimiter("//[*][!!][r9r]\n11");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test_Numbers_Greater_Than_OneThousand()
        {

            int expected = 77;

            int actual = Program.Custom_Delimiter("//[*][!!][r9r]\n11r9r22*1001!!44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Multi_Delimiter_Test_Numbers_Negative_Numbers()
        {


            Action act = () => Program.Custom_Delimiter("//[*][!!][r9r]\n11r9r22*-33!!44");
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test()
        {

            int expected = 66;

            int actual = Program.Custom_Delimiter("//*\n11*22*33");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test_Invalid_Numbers()
        {

            int expected = 44;

            int actual = Program.Custom_Delimiter("//*\n11r9r22*44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test_Invalid_Numbers_Missing_Numbers()
        {

            int expected = 55;

            int actual = Program.Custom_Delimiter("//*\n11**44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test_New_Line()
        {

            int expected = 76;

            int actual = Program.Custom_Delimiter("//*\n11*33*22\n10");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test_With_Missing_Numbers()
        {

            int expected = 11;

            int actual = Program.Custom_Delimiter("//*\n11");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test_Numbers_Greater_Than_OneThousand()
        {

            int expected = 77;

            int actual = Program.Custom_Delimiter("//*\n11*22*1001*44");

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Add_Custom_Single_Char_Delimiter_Test_Numbers_Negative_Numbers()
        {


            Action act = () => Program.Custom_Delimiter("//*\n11*22*-33*44");
            Assert.Throws<ArgumentException>(act);
        }
    }
}
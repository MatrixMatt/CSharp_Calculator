using System;

namespace CSharp_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int SimpleCommaDelimiter(string userInput){
            int inputTotal = 0;
            string[] userInputArray = userInput.Split(',','\n');

            foreach(string value in userInputArray){
                inputTotal += int.Parse(value);
            }
            return inputTotal;
        }
    }
}

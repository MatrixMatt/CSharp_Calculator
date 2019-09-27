using System;

namespace CSharp_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Simple_Comma_Delimiter(string userInput){
            try{
                int inputTotal = 0;
            string[] userInputArray = userInput.Split(',','\n');

            foreach(string x in userInputArray){
                string value = Utility.Input_Value_Validation(x);               
                if (int.Parse(value) < 0){
                 throw new Exception( value + " cannot be used due to being a negative number");
            
                }else{
                    inputTotal += int.Parse(value);
                }              
            }
            return inputTotal;
            }catch(Exception ex){
                System.ArgumentException argEx = new System.ArgumentException(ex.Message);
               throw argEx;
            }
            
        }
    }
}

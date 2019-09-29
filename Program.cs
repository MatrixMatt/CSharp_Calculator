using System;
using System.Linq;
using System.Text;
namespace CSharp_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo inputStringArray;
            String inputString = "";
            int output = 0;
            Console.WriteLine("String Calculator (press esc to exit)");
            Console.WriteLine("Please enter string:");
            inputStringArray = Console.ReadKey();

            while(inputStringArray.KeyChar != (char)13){
                if(inputStringArray.Key == ConsoleKey.Escape){
                    return;
                }else{
                    sb.Append(inputStringArray.KeyChar);
                inputString += inputStringArray.KeyChar.ToString();
                inputStringArray = Console.ReadKey();
                }
                
            }
            
            inputString = sb.ToString().Replace("\\n","\n");
            if(inputString.IndexOf("//") > -1){
                output = Custom_Delimiter(inputString.Trim());
            }else{
                output = Simple_Comma_Delimiter(inputString.Trim());
            }

            Console.WriteLine("\n Your total = {0}", output.ToString());
            }
            
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
        public static int Custom_Delimiter(string userInput){

            try{
                int inputTotal = 0;
                 if(userInput.IndexOf("//[") > -1){
                string delimiterString = userInput.Substring(2);
                string[] delimiter = Utility.Custom_Delimiter_Value(delimiterString);
                string numberString = Utility.Custom_Delimiter_Number_String_value(delimiterString);
                string[] userInputArray = numberString.Split(delimiter, StringSplitOptions.None);

                foreach(string x in userInputArray){
                string value = Utility.Input_Value_Validation(x);               
                if (int.Parse(value) < 0){
                 throw new Exception( value + " cannot be used due to being a negative number");
            
                }else{
                    inputTotal += int.Parse(value);
                }              
            }
            return inputTotal;
            } else if(userInput.IndexOf("//") > -1){
                string delimiterString = userInput.Substring(2);
                char[] delimiter = Utility.Custom_Delimiter_Single_Character_Value(delimiterString);
                string numberString = Utility.Custom_Delimiter_Number_String_value(delimiterString);
                string[] userInputArray = numberString.Split(delimiter);
                foreach(string x in userInputArray){
                string value = Utility.Input_Value_Validation(x);               
                if (int.Parse(value) < 0){
                 throw new Exception( value + " cannot be used due to being a negative number");
            
                }else{
                    inputTotal += int.Parse(value);
                }              
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

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace CSharp_Calculator
{
    public class Utility
    {
        public static string Input_Value_Validation(string input)
        {
            int output;
            if (!int.TryParse(input, out output))
            {
                return "0";
            }
            else if (output > 1000)
            {
                return "0";
            }
            else
            {
                return input;
            }

        }
        public static char[] Custom_Delimiter_Single_Character_Value(string input){
            char output;
            char[] outputArray;
            string[] delimiterValue = input.Split('\n');
            if(delimiterValue.Length > 0){
                output = char.Parse(delimiterValue[0][0].ToString());
                 outputArray = new char[] {output, '\n'};
                return outputArray;
            }
             outputArray = new char[] {'\n'};
            return outputArray;
            
        }
        public static string[] Custom_Delimiter_Value(string input)
        {
            string[] output = {"\n"};
            List<string> delimiterList = new List<string>();
            string[] delimValues = input.Split('\n');
            if (delimValues.Length > 0)
            {
                System.Text.RegularExpressions.MatchCollection delimiterMatches = Regex.Matches(delimValues[0].ToString(), @"\[(.*?)\]");
                foreach (System.Text.RegularExpressions.Match match in delimiterMatches)
                {
                    delimiterList.Add(match.Groups[1].Value);
                    
                }
                delimiterList.Add("\n");
                output = delimiterList.ToArray();
                return output;
            }
            return output;


        }
        public static string Custom_Delimiter_Number_String_value(string input){
            string output = "";
            string[] delimValues = input.Split('\n');
            if(delimValues.Length > 0){
                for (int i = 1; i < delimValues.Length; i++){
                    output += output == ""? delimValues[i].ToString():"\n" + delimValues[i].ToString();
                }
                return output;
            }
            return output;
        }
    }
}
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
            string[] delimValues = input.Split('\n');
            if(delimValues.Length > 0){
                return delimValues[1].ToString();
            }
            return "";
        }
    }
}
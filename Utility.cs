namespace CSharp_Calculator
{
    public class Utility
    {
        public static string Input_Value_Validation(string input){
            int output;
            if(!int.TryParse(input, out output)){
                return "0";
            }else if(output > 1000){
                return "0";
            }else{
                return input;
            }

        }
    }
}
namespace CalculatorKata
{
    public class BalanceBrackets
    {
        public string CheckForBalancedBrackets(string input)
        {
            var bracketCount = 0;
            foreach (var item in input.ToCharArray())
            {
                if (item == '[')
                {
                    bracketCount++;
                }
                else
                {
                    bracketCount--;
                }
                if (bracketCount < 0)
                {
                    return "FAIL";
                }
               
            }
            return bracketCount == 0 ? "OK" : "FAIL";
        }
    }
}

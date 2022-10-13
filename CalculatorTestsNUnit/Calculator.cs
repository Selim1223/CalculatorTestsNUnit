namespace CalculatorTestsNUnit
{
    public static class Calculator
    {

       /* private static string GetDelimiter(string numbers)
        {
            if (numbers.StartsWith("//"))
                
            return "," ;
        }
       */

        public static int Add(string numbers)
        {
            if (numbers == null || numbers == "")
                return 0;

            var arrayNumbers = numbers.Split(',','\n');

            var result = arrayNumbers
                .Where(number => Convert.ToInt32(number)<=1000)
                .Sum(chainNumber => Convert.ToInt32(chainNumber));
            return result;
        }
    }
}

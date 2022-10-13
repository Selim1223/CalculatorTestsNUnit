namespace CalculatorTestsNUnit
{
    public static class Calculator
    {

        public static int Add(string numbers)
        {
            if (numbers == null || numbers == "")
                return 0;

            var arrayNumbers = numbers.Split(',','\n');

            var result = arrayNumbers.Where(number => Convert.ToInt32(number)<=1000).Sum(sumNumber => Convert.ToInt32(sumNumber));
            return result;
        }
    }
}
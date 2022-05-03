namespace CalculatorFunctions
{
    public static class Functions
    {
        public static double? Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double? Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double? Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double? Divide(double num1, double num2)
        {
            //Now this function will return null if num2 is 0
            if (num2 == 0)
            {
                return null;
            }
            return num1 / num2;
        }
    }
}

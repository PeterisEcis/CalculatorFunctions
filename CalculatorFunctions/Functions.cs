namespace CalculatorFunctions
{
    public static class Functions
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            //For now this function is left without any checks intentionally
            //Later I will add safety checks if num2 is not 0
            return num1 / num2;
        }
    }
}

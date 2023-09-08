namespace CalcLib
{
    public class Calculator
    {
        public double Add (double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multi(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Avg(double num1, double num2)
        {
            return (num1 + num2) / 2;
        }
    }
}
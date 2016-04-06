using System;

namespace Calculator
{
    public class Calculating
    {
        public static double Addition(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public static double Substraction(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

        public static double Multiplication(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public static double Division(double firstArgument, double secondArgument)
        {
            if((secondArgument-0)<double.Epsilon)
                throw new Exception("Division to zero is bad\n");

            return firstArgument / secondArgument;
        }

        public static double Mod(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }
    }
}

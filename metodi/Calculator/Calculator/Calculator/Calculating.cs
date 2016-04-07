using System;

namespace Calculator
{
    public class Calculating
    {
        public double Addition(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public double Substraction(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

        public double Multiplication(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public double Division(double firstArgument, double secondArgument)
        {
            if((secondArgument-0)<double.Epsilon)
                throw new Exception("Division to zero is bad\n");

            return firstArgument / secondArgument;
        }

        public double Mod(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }
    }
}

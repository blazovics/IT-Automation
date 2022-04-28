using System;
using System.Collections.Generic;
using System.Text;

namespace UltimateApp
{
    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Modulo
    }

    public class Calculator
    {
        private static int Add (int a, int b)
        {
            return a + b;
        }

        private static int Subtract (int a, int b)
        {
            return a - b;
        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }

        private static int Divide(int a, int b)
        {
            return a / b;
        }

        private static int Modulo(int a, int b)
        {
            return a /b;
        }

        public static int? calculate(int a, int b, Operation o)
        {
            switch (o)
            {
                case Operation.Add:
                    return Add(a, b);

                case Operation.Subtract:
                    return Subtract(a, b);

                case Operation.Multiply:
                    return Multiply(a, b);

                case Operation.Divide:
                    return Divide(a, b);

                case Operation.Modulo:
                    return Divide(a, b);

                default:
                    return null;
            }
        }
    }
}
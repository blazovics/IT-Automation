using System;

namespace UltimateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a, b;

            a = getInputOperands("Give first operand");

            Operation? o = getOperationType("Give operation type {+,-,*,/,%}");

            b = getInputOperands("Give second operand");

            if (a!=null && b!=null && o != null)
            {
                Console.WriteLine(a + " " + o.ToString() + " " + b + " = " + Calculator.calculate(a.Value,b.Value,o.Value));
            }
            else
            {
                Console.WriteLine("Bad input");
            }

            
        }

        private static int? getInputOperands(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (input != null)
            {
                try
                {
                    int result = Int32.Parse(input);
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{input}'");
                }
            }
            return null;
        }

        private static Operation? getOperationType(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (input != null)
            {
                switch (input)
                {
                    case "+":
                        return Operation.Add;
                    case "-":
                        return Operation.Subtract;
                    case "*":
                        return Operation.Multiply;
                    case "/":
                        return Operation.Divide;
                    case "%":
                        return Operation.Modulo;
                }
            }
            return null;
        }
    }
}

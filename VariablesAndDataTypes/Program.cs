using System;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            num1 = 5;
            int num2 = 1;
            //Console.WriteLine("Sum of "+ num1+ " and "+num2+" is: "+(num1+num2));

            //multiple variables
            double a, b, c;
            a = 5;
            b = 2.67;
            //Console.WriteLine("A = " + a+ ", B = " + b+" = "+ (a/b));

            //floating point variables
            float f1 = 5.02f;
            float f2 = 2.22f;
            float fDiv = f1 / f2;
            //Console.WriteLine("F1/F2 = " + fDiv);

            //String manipulation
            String myName = "Igor";
            Console.WriteLine(myName);

        }
    }
}

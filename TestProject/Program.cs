using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers\n");
            int Number1;
            int Number2;
            Number1 = int.Parse(Console.ReadLine());
            Number2 = int.Parse(Console.ReadLine());

            MathsHelper helper = new MathsHelper();
            int x = helper.Add(Number1, Number2);
            Console.WriteLine("\nThe sum of " + Number1 +
                " and " + Number2 + " is " + x);
            Console.ReadKey();
            int y = helper.Subtract(Number1, Number2);
            Console.WriteLine("\nThe difference between " +
                  Number1 + " and" + Number2 + "  is " + y);
            Console.ReadKey();
        }
    }

    public class MathsHelper
    {
        public MathsHelper() { }
        public int Add(int A, int B)
        {
            int X = A + B;
            return X;
        }

        public int Subtract(int A, int B)
        {
            int X = A - B;
            return X;
        }
    }
}



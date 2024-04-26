using System;
namespace Calculator3
{
    public class Program
    {
        static double InputA;
        static double InputB;
        public static double Add(double a, double b)
        {
            return a + b;
        }


        public static double Subtract(double a, double b)
        {
            return a - b;
        }


        public static double Multiply(double a, double b)
        {
            return a * b;
        }


        public static double Divide(double a, double b)
        {
            return a / b;
        }


        public static double Equals(double a, double b)
        {
            if (a == b)
            {
                return 1;
            }
            return 0;
        }

        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Log(double a, double b)
        {
            return Math.Log(a, b);
        }
        public static double Root(double a, double b)
        {
            return Math.Pow(a, 1.0 / b);
        }

        public static double Factorial(double n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static double SinA(double a)
        {
            double radians = a * Math.PI / 180; // Convert degrees to radians
            return Math.Sin(radians);
        }
        public static double CosA(double a)
        {
            double radians = a * Math.PI / 180; // Convert degrees to radians
            return Math.Cos(radians);
        }
        public static double TanA(double a)
        {
            double radians = a * Math.PI / 180; // Convert degrees to radians
            return Math.Tan(radians);
        }
        public static double Reciprocal(double a)
        {
            if (a == 0)
            {
                return 2;
            }
            return 1 / a;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Input Value For A");
            InputA = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Value For B");
            InputB = double.Parse(Console.ReadLine());

            Console.WriteLine("Add A + B - Enter 0");
            Console.WriteLine("Subtrack A - B - Enter 1");
            Console.WriteLine("Multiply A * B - Enter 2");
            Console.WriteLine("Dvide A / B - Enter 3");
            Console.WriteLine("Equals A == B - Enter 4");
            Console.WriteLine("Power A ^ B - Enter 5");
            Console.WriteLine("Log A log B - Enter 6");
            Console.WriteLine("Root A root B - Enter 7");
            Console.WriteLine("Sin A - Enter 9");
            Console.WriteLine("Cos A - Enter 10");
            Console.WriteLine("Tan A - Enter 11");
            Console.WriteLine("Reciprocal 1 / A - Enter 12");

            Console.WriteLine(" ");


            Console.Write("this is Add - "); Add(InputA, InputB);
            Console.Write("this is Subtract - "); Subtract(InputA, InputB);
            Console.Write("this is Multiply - "); Multiply(InputA, InputB);
            Console.Write("this is Divide - "); Divide(InputA, InputB);
            Console.Write("this is Equals - "); Equals(InputA, InputB);
            Console.Write("this is Power - "); Power(InputA, InputB);
            Console.Write("this is Log - "); Log(InputA, InputB);
            Console.Write("this is Root - "); Root(InputA, InputB);
            Console.Write("this is Factorial - "); Factorial(InputA);
            Console.Write("this is Sin A - "); SinA(InputA);
            Console.Write("this is Cos A - "); CosA(InputA);
            Console.Write("this is Tan A - "); TanA(InputA);
            Console.Write("this is Reciprocal - "); Reciprocal(InputA);

        }
    }
}
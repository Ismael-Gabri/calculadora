using System;

namespace Calculator
{
    class program   
    {
        static void Main(string[] args)
        {
            bool quitApp = false;

            double t;
            double u;

            do
            {
                //To prompt the user for an opertaion
                Console.WriteLine("What mathematic operation you wish to make? +, -, *, / or quit?");
                var answer = Console.ReadLine();


                //To execute the operation
                switch (answer)
                {
                    case "+":
                        Console.Write("First Number: ");
                        t = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second Number: ");
                        u = Convert.ToDouble(Console.ReadLine());

                        ToSum(t, u);
                        break;
                    case "-":
                        Console.Write("First Number: ");
                        t = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second Number: ");
                        u = Convert.ToDouble(Console.ReadLine());

                        ToSubtract(t, u);
                        break;
                    case "*":
                        Console.Write("First Number: ");
                        t = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second Number: ");
                        u = Convert.ToDouble(Console.ReadLine());

                        ToMultiply(t, u);
                        break;
                    case "/":
                        Console.Write("First Number: ");
                        t = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second Number: ");
                        u = Convert.ToDouble(Console.ReadLine());

                        ToDivide(t, u);
                        break;
                    case "quit":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, this is not a valid answer");
                        Console.WriteLine(" ");
                        break;
                }
            }
            while (!quitApp);
        }

        //Function to MULTIPLY
        static double ToMultiply(double a, double b)
        {


            double result = a * b;
            Console.WriteLine("Your result is: " + result);
            Console.WriteLine(" ");
            return result;
        }

        //Function to SUM
        static double ToSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Your result is: " + sum);
            Console.WriteLine(" ");
            return sum;
        }

        //Function to subtract 
        static double ToSubtract(double r, double s)
        {
            double sub = r - s;
            Console.WriteLine("Your result is: " + sub);
            Console.WriteLine(" ");
            return sub;
        }

        //Function to divide
        static double ToDivide(double c, double d)
        {
            double div = c / d;
            Console.WriteLine("Your result is: " + div);
            Console.WriteLine(" ");
            return div;
        }

    }
}
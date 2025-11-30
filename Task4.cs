using System;

class ArithmeticCalculator
{

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main(string[] args)
    {
        char repeat = 'Y';

        while (repeat == 'Y' || repeat == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Input values
            Console.Write("Enter Value 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            string symbol = "";

            // Switch Case for Operation

            switch (choice)
            {
                case 1:
                    result = Add(v1, v2);
                    symbol = "+";
                    break;

                case 2:
                    result = Subtract(v1, v2);
                    symbol = "-";
                    break;

                case 3:
                    result = Multiply(v1, v2);
                    symbol = "*";
                    break;

                case 4:
                    if (v2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                        continue; // restart loop
                    }
                    result = Divide(v1, v2);
                    symbol = "/";
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    continue;
            }

       // Display ouput

            Console.WriteLine($"{v1} {symbol} {v2} = {result}");

            Console.Write("Do you want to continue again (Y/N)? ");
            repeat = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("Program Ended. Goodbye!");
    }
}

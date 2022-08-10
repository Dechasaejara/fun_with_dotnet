using System;
namespace Algebra
{
    public class Fractions
    {
        public static void RunFractions()
        {
            Console.Clear();
            char repeat = 'y';
            do
            {
                Console.WriteLine($"Select Your Choice.");
                Console.WriteLine($"1. Decimal To Fractions");
                Console.WriteLine($"2. Fraction to Decimal");
                Console.WriteLine($"4. Main Menu");
                Console.WriteLine($"5. Exit");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: DecimalToFraction(); break;
                    case 2: fractionToDecimal(); break;
                    case 4: having_Fun.Program.Runmain(); break;
                    case 5: System.Environment.Exit(0); break;
                    default:
                        Console.WriteLine($"Invalid Input!"); break;

                }
                Console.WriteLine($"Do you want try again ?");
                Console.WriteLine($"y or n");
                repeat = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (repeat == 'y');
        }
        static void fractionToDecimal()
        {
            Console.Clear();
            Console.WriteLine($"Enter numunator to Convert to Decimal.");
            float numunator = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Denumunator to Convert to Decimal.");
            float denumunator = float.Parse(Console.ReadLine());
            float Result = numunator / denumunator;
            Console.WriteLine($"{numunator}/{denumunator} is {Result}.");
        }
        static void DecimalToFraction()
        {
            Console.Clear();
            Console.WriteLine($"Enter Decimal To Convert to Fractions.");
            string numunator = Console.ReadLine();
            if (numunator.Contains('.'))
            {
                int pointIndex = numunator.IndexOf('.');
                String afterPoint = numunator.Substring(pointIndex, numunator.Length - 1);
                Console.WriteLine($"{afterPoint}");
            }
            else
            {
                Console.WriteLine($"Invalid Inuput!.");

            }


            // float Result = numunator / denumunator;
            // Console.WriteLine($"{numunator}/{denumunator} is {Result}.");
        }
    }
}
using System;
using Algebra;
namespace having_Fun
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Runmain();
        }
        public static void Runmain()
        {
            Console.Clear();
            char repeat = 'y';
            do
            {
                Console.WriteLine($"Select Your Choice.");
                Console.WriteLine($"1. Algebra");
                Console.WriteLine($"2. Bank Short Codes");
                Console.WriteLine($"5. Exit");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: RunAlgebra.runAlgebra(); break;
                    case 2: Bank.RunBank(); break;
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
    }
}

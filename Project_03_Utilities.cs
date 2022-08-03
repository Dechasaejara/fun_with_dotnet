using System;

namespace having_Fun
{
    public class Utilities
    {
        public static void RunUtilities()
        {
            Console.Clear();
            Console.WriteLine($"What Do you want to Calculate?");
            Console.WriteLine($"1. Temprature ");
            Console.WriteLine($"2. Exit");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1: Temprature.RunTemprature(); break;
                case 0: break;
                default: Console.WriteLine($"Invalid Input!"); break;
            }

        }
        public class Temprature
        {
            public static void RunTemprature()

            {
                Console.Clear();
                Console.WriteLine($"Enter Your Choice.");
                Console.WriteLine($"Press 1 Frahnit to Celius.");
                Console.WriteLine($"Press 2 Celius to Frahnit");
                Console.WriteLine($"Press 0 Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: Tocelius(); break;
                    case 2: Tofrahnit(); break;
                    default: Console.WriteLine($"Invalid Input!"); break;
                }

            }
            static void Tocelius()
            {
                Console.WriteLine($"Enter temprature in frahnit");
                float frahnit = float.Parse(Console.ReadLine());
                float celius = ((frahnit - 32) * 5 / 9);
                Console.WriteLine($"{celius} Celius");
            }
            static void Tofrahnit()
            {
                Console.WriteLine($"Enter temprature in Celius");
                float celius = float.Parse(Console.ReadLine());
                float frahnit = ((celius * 9) + 32);
                Console.WriteLine($"{frahnit} frahnit");
            }
        }
        public class MyClass
        {
            
        }
    }
}
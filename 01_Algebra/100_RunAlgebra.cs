namespace Algebra
{
    public class RunAlgebra
    {
        public static void runAlgebra()
        {
            Console.Clear();
            char repeat = 'y';
            do
            {
                Console.WriteLine($"Select Your Choice.");
                Console.WriteLine($"1. Percentage");
                Console.WriteLine($"4. Back");
                Console.WriteLine($"5. Exit");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: Percentage.RunPercentage(); break;
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

    }
}

namespace Algebra
{
    public class Percentage
    {
        public static void RunPercentage()
        {
            Console.Clear();
            char repeat = 'y';
            do
            {
                Console.WriteLine($"Select Your Choice.");
                Console.WriteLine($"1. Find Percentage");
                Console.WriteLine($"2. Find Percentile");
                Console.WriteLine($"3. Find Total Value.");
                Console.WriteLine($"4. Main Menu");
                Console.WriteLine($"5. Exit");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: findPercentage(); break;
                    case 2: findValue(); break;
                    case 3: findTotalValue(); break;
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
        static void findPercentage()
        {
            Console.Clear();
            Console.WriteLine($"Enter Total value to Calculate Percent.");
            float total_value = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter value to Calculate Percent.");
            float value = float.Parse(Console.ReadLine());
            float percent = (value / total_value) * 100;
            Console.WriteLine($"{value} is {percent}% of {total_value}.");
        }
        static void findValue()
        {
            Console.Clear();
            Console.WriteLine($"Enter Total value to Calculate Percent.");
            float total_value = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Percentage to Calculate value.");
            float percent = float.Parse(Console.ReadLine());
            float value = (percent * total_value) / 100;
            Console.WriteLine($"{percent}% of {total_value} is {value}");
        }
        static void findTotalValue()
        {
            Console.Clear();
            Console.WriteLine($"Enter Percentile to Calculate total value.");
            float percentile = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Percentage to Calculate total value.");
            float percentage = float.Parse(Console.ReadLine());
            float tvalue = (100 * percentile) / percentage;
            Console.WriteLine($"Total value of {percentile} and {percentage}% is {tvalue}.");
        }
    }
}
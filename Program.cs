using System;
namespace having_Fun
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Invoke Swapper class
            // Swapping.RunSwapp();

            // Invoke Palindrome class
            // Palindrome.RunPalindrome();


            // Invoke Utilities class
            char repeat = 'y';
            do
            {
                Utilities.RunUtilities();
                Console.WriteLine($"Do you want try again ?");
                repeat = char.Parse(Console.ReadLine());
            } while (repeat == 'y');
        }
    }
}

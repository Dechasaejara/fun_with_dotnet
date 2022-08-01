// Palindrome number is a number that is going to be the same after reversing the digits of that number.
using System;
namespace having_Fun
{
    public class Palindrome
    {
        public static void RunPalindrome()
        {
           NunPalindrome(); 
        }
        static void NunPalindrome(){
            int sum = 0, reminder;
            Console.WriteLine($"Enter Palindrome Number.");     
            int numInput= Convert.ToInt32(Console.ReadLine());
            int temp = numInput; 
            while (numInput> 0)
            {
                reminder = numInput % 10;
                sum = (sum * 10) + reminder;
                numInput = numInput / 10;
            }
            Console.WriteLine($"Input :{ numInput}");        
            if(temp == numInput){
                Console.WriteLine($"Number : {temp} is Palindrome");     
            }
            else {
                Console.WriteLine($"Number : {temp} is NOT Palindrome");     
            }
        }
    }
}
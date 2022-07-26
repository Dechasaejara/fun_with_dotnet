using System;
namespace having_Fun
{
    public  class Swapping
    {
      public static  void RunSwapp(){
        // choice what to Swap
        Console.WriteLine("What do you want to swap?");
        Console.WriteLine("press 1 Numbers");
        Console.WriteLine("press 2 Names");
        Console.WriteLine("press 0 exit");
        int input=Convert.ToInt32( Console.ReadLine());
            switch (input)
            {
                case 1:
           SwapNum();            
                    break;
                case 2: 
           SwapName();            
                    break;
                case 0:           
                    Console.Clear();
                    break;
                default:
                Console.WriteLine("Sorry, Wrong Choice!");
                    break;
            }
        }

            //    Number Swapper
      static   void SwapNum()
        {  
            Console.WriteLine("Enter first number");
            int   num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter second number");
            int   num2 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Before SWapping number1= {num1}, number2 = {num2}"); 

            int temp;
            temp=num1;
            num1=num2;
            num2=temp;
           
            Console.WriteLine($"After SWapping number1= {num1}, number2 = {num2}");    
                     
        }
        // String Swapper
       static  void SwapName()
        {
            Console.WriteLine("Enter first name");
            string   f_name = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string   l_name = Console.ReadLine();
            Console.WriteLine($"Before SWapping first name= {f_name}, last name = {l_name}"); 

            String temp;
            temp=f_name;
            f_name=l_name;
            l_name=temp;
           
            Console.WriteLine($"After SWapping first name= {f_name}, last name = {l_name}"); 
            
            
        }
    }
}
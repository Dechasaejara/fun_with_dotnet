
// namespace Algebra
// {
//     public class Avg
//     {
//         public static void RunAvg()
//         {
//             {
//                 Console.Clear();
//                 char repeat = 'y';
//                 do
//                 {
//                     Console.WriteLine($"Select Your Choice.");
//                     Console.WriteLine($"1. Percentage");
//                     Console.WriteLine($"4. Back");
//                     Console.WriteLine($"5. Exit");

//                     switch (int.Parse(Console.ReadLine()))
//                     {
//                         case 1: Percentage.RunPercentage(); break;
//                         case 4: having_Fun.Program.Runmain(); break;
//                         case 5: System.Environment.Exit(0); break;
//                         default:
//                             Console.WriteLine($"Invalid Input!"); break;

//                     }
//                     Console.WriteLine($"Do you want try again ?");
//                     Console.WriteLine($"y or n");
//                     repeat = char.Parse(Console.ReadLine());
//                     Console.Clear();
//                 } while (repeat == 'y');
//             }
//         }
//         static void ArthimaticAvg()
//         {
//             int[] answer = new int[10];
//             for (int i = 0; i < answer.length; i++)
//             {
//                 answer[i] = Console.ReadLine();
//             }
//         }
//     }
// }
using System;
using System.IO;
namespace having_Fun
{
    public class Bank
    {
        public static void RunBank()
        {
            if (File.Exists("./04_Finance/BankShortCodes.txt"))
            {
                string content = File.ReadAllText("./04_Finance/BankShortCodes.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            while (newContent != "exit")
            {
                File.AppendAllText("./04_Finance/BankShortCodes.txt", newContent + Environment.NewLine);
                newContent = Console.ReadLine();
            }

        }
    }
}
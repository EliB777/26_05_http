using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _26_05_http
{
    internal class files
    {
        public static void ShowManu()
        {
            bool ShowManu = true;
            while (ShowManu)
            {
                Console.WriteLine(
                    $"Manu: \n " +
                    $"" +
                    $"To write file press 1: \n " +
                    $"Exit press * \n");
                string line = Console.ReadLine();
                if (line == "")
                {
                    Console.WriteLine("enter valid data!");
                    continue;
                }
                char choice = line.ToCharArray()[0];
                switch (choice)
                {
                    case '1':
                        writeFile();
                        break;
                    case '*':
                        ShowManu = false;
                        break;

                }
            }
        }
        public static void writeFile()
        {

            Console.WriteLine("enter text");
            string text = Console.ReadLine();
            Console.WriteLine("enter file name");
            string fileName = Console.ReadLine();
            fileName = fileName.Split('.')[0] + ".txt";
            File.WriteAllText(fileName, text);
            Console.WriteLine("succes save file on: " + fileName);

        }
        public static void readFile()
        {
            Console.WriteLine("enter file name");
            string readFile = File.ReadAllText(@"C:\Users\elibl\c#_test");
            Console.WriteLine(readFile.ToUpper());
        }
    }
}

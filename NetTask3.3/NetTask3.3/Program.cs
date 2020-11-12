//Записать метод, возвращающий число вхождений подстроки в строку. Строка и подстрока
//являются неизменяемыми параметрами метода. 
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Text;

namespace NetTask3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"1text1.txt";
            string str = "", sBstring;
            int wh = 1;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(path, Encoding.Default);               
                str += sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(str + "\n\n");

            Console.Write("Enter an substring: ");
            sBstring = Console.ReadLine();

            Console.WriteLine(quantityOfEntrances(str, sBstring));

            while (wh == 1)
            {
                Console.WriteLine("if you would enter your string press 1\nif you would close app press 0\n\n");
                wh = Convert.ToInt32(Console.ReadLine());
                if (wh == 1)
                {
                    Console.WriteLine("Enter your string: ");
                    str = Console.ReadLine();

                    Console.WriteLine("Enter an substring: ");
                    sBstring = Console.ReadLine();

                    Console.WriteLine(quantityOfEntrances(str, sBstring));
                }
                else break; 
            } 

        }

        static int quantityOfEntrances(string str, string sBstring)
        {
            int quantity = 0;
            int sBstrLength = sBstring.Length;
            int strLength = str.Length;
            

            for (int i = 0; i < strLength - (sBstrLength - 1) ; i++)
            {      
                for (int j = 0; j < sBstrLength; j++)
                {              
                    if (str[i + j] == sBstring[j])
                    {
                        if (j == sBstrLength - 1)
                        {
                            quantity++;
                            break;
                        }
                        continue;
                    }
                    else break;
                }
            }
            return quantity;
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SplitWord(string text) // 
            {
                string[] wordsSplit = text.Split(' ');
                string newText = ReverseWords(wordsSplit);
                return newText;
            }
            string ReverseWords(string[] text) // 
            {
                Array.Reverse(text);
                string str = string.Join(" ", text);
                return str;
            }
            
            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine("Введите предложение: ");

            string test2 = Console.ReadLine();

            test2 = SplitWord(test2);


            Console.WriteLine(test2);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {

        static void SplitText(string text)
        {
            //text = Console.ReadLine();
            string[] splited = text.Split(' ');
            foreach (var i in splited)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();

            SplitText(text);
            Console.ReadKey();
        }
    }
}

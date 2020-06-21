using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract7_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение: ");
            string text = (Console.ReadLine());
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 1)
                    Console.Write(words[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma coisa:");
            string s = Console.ReadLine();

            Console.WriteLine("Digite o caráter que deseja remover:");
            string c = Console.ReadLine();

            char c1 = char.Parse(c);

            string ns = "";

            foreach (char l in s)
            {
                if (l == c1)
                {
                    ns += 'x';
                }
                else
                {
                    ns += l;
                }
            }

            Console.WriteLine(ns);

        }
    }
}

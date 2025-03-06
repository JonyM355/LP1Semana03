using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string p in args)
            {
                if (p.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }

                if (p.Length > 3)
                {
                    Console.WriteLine($"{p} ");
                }

            }
        }
    }
}

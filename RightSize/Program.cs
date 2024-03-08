using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Length > 3 & s.Length <6) //If the string has more than 3
                                                //and less than 6 characters
                {
                    Console.WriteLine(s);
                }
                if (s.Length > 6)
                {
                    return;
                }
            }
        }
    }
}

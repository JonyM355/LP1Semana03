using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s = args[0].ToLower();

            Perks myperks = 0;

            foreach (char c in s)
            {
                switch (c)
                {
                    case 'w': myperks ^= Perks.WarpShift; break;
                    case 'a': myperks ^= Perks.AutoHeal; break;
                    case 's': myperks ^= Perks.Stealth; break;
                    case 'd': myperks ^= Perks.DoubleJump; break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }

            if (myperks == 0)
            {
                Console.WriteLine("!No perks at all!");
            }
            else
            {
                Console.WriteLine(myperks);
            }

            if ((myperks & (Perks.Stealth ^ Perks.DoubleJump))
                == (Perks.Stealth ^ Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }

            if ((myperks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}

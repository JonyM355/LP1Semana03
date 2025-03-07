using System;
using System.Net;
using System.Xml.XPath;

namespace WeaponSelector
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {

            if (args.Length < 2)
            {
                Weapons w = Weapons.None;
                return w;
            }
            else
            {
                Weapons w = Enum.Parse<Weapons>(args[1]);
                return w;
            }
            // ////////// //
            // CHANGE ME! //
            // ////////// //
        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            bool result = true;

            if ((enemy == EnemyType.Ghost) && (weapons == Weapons.HolyWater)
                ||
                (enemy == EnemyType.Vampire) && (weapons == Weapons.Garlic) ||
                                                (weapons == Weapons.HolyWater)
                ||
                (enemy == EnemyType.Werewolf) &&
                (weapons == Weapons.SilverBullet)
                ||
                (enemy == EnemyType.Zombie) && 
                (weapons == Weapons.SilverBullet))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
            // ////////// //
            // CHANGE ME! //
            // ////////// //
        }

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            if (survives == true)
            {
                Console.WriteLine($"{enemy} dies");
            }
            
            else
            {
                Console.WriteLine($"{enemy} survives");
            }
            // ////////// //
            // CHANGE ME! //
            // ////////// //
        }
    }
}

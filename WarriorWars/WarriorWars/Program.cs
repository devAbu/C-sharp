using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
    class Program
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Abu", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Combe", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                //Thread.Sleep(500);
            }
        }
    }
}

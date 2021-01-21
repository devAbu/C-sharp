using System;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            { 
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;

            this.isAlive = true; // this keywork can be removed

            switch (faction)
            {
                case Faction.GoodGuy:
                    this.weapon = new Weapon(faction);
                    this.armor = new Armor(faction);
                    this.health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    this.weapon = new Weapon(faction);
                    this.armor = new Armor(faction);
                    this.health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} died! ", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} won!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}...{damage} damage was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.health}");
            }
        }
    }
}

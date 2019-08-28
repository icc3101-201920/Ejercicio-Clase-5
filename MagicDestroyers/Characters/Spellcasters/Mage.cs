using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage: Spellcaster
    {


        public Mage() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level) : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new ClothRobe();
            this.Weapon = new Staff();
        }


        public override void Attack()
        {
            Console.WriteLine("I have trained for 50 years, but I only can do Fireball!");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Take my special attack! Fireball!");
        }

        public override void Defend()
        {
            Console.WriteLine("I will defend myself! Fireball!");
        }
    }
}

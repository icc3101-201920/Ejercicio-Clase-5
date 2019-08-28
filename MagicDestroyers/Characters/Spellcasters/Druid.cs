using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {

        public Druid() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Druid(string name, int level) : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Staff();
        }


        public override void Attack()
        {
            Console.WriteLine("The night has come, the fire is cold");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Feel the power of the sky");
        }

        public override void Defend()
        {
            Console.WriteLine("We are Stardust");
        }
    }
}

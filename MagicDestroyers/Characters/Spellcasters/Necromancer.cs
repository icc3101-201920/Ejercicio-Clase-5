using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer: Spellcaster
    {
        public Necromancer() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Necromancer(string name, int level) : this(name, level, DEFAULT_MANA_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

        public override void Attack()
        {
            Console.WriteLine("The power of the darkness is here");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Vampires, go and attack!");
        }

        public override void Defend()
        {
            Console.WriteLine("The femur is the strongest bone of the human, my armor is made by a hundred of them");
        }
    }
}

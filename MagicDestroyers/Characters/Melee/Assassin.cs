using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin: Melee
    {
        public Assassin() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level) : this(name, level, DEFAULT_ABILTY_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

  
        public override void Attack()
        {
            Console.WriteLine("(whisper) Feel the rage of my blade...");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("50 thousand stabs!");
        }

        public override void Defend()
        {
            Console.WriteLine("No one can kill me, I will survive!");
        }
    }
}

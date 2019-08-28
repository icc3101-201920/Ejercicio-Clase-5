using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior: Melee
    {
       
        public Warrior(): this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level): this(name, level, DEFAULT_ABILTY_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints): base(name, level, healthPoints)
        {
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }
        

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} Strike!");
        }
        public override void SpecialAttack()
        {
            Console.WriteLine($"{this.Name} Execute!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{this.Name} skin hard like rock!");
        }

        

    }
}

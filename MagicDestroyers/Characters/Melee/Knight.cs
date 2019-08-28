using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight: Melee
    {

        public Knight() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Knight(string name, int level) : this(name, level, DEFAULT_ABILTY_POINTS)
        {
        }

        public Knight(string name, int level, int healthPoints) : base(name, level, healthPoints)
        {
            this.BodyArmor = new Chainlink();
            this.Weapon = new Hammer();
        }

        public override void Attack()
        {
            Console.WriteLine("Feel the power of God!");
        }

        public override void Defend()
        {
            Console.WriteLine("My armor is harder than steel");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Get out your demons!");
        }
    }
}

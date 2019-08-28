using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword: Weapon
    {

        public Sword(): base()
        {
            base.Damage = DEFAULT_DAMAGE_SWORD;
        }

        public override void Attack()
        {
            Console.WriteLine("BloodThirst");
        }
        public override void SpecialAttack()
        {
            Console.WriteLine("DoubleStab");
        }
    }
}

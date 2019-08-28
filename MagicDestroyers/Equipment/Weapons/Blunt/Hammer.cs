using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer: Weapon
    {
    
        public Hammer():base()
        {
            base.Damage = DEFAULT_DAMAGE_HAMMER;
        }

        public override void Attack()
        {
            Console.WriteLine("Stun");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("ThrowHammer");
        }
    }
}

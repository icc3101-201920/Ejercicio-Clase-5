using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe: Weapon
    {
        public Axe(): base()
        {
            base.Damage = DEFAULT_DAMAGE_AXE;
        }

        public override void Attack()
        {
            Console.WriteLine("HackNSlash");
        }
        public override void SpecialAttack()
        {
            Console.WriteLine("RageFury");
        }
    }
}

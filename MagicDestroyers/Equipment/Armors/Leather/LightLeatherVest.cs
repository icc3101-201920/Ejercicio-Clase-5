using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest: Armor
    {
        public LightLeatherVest(): base()
        {

        }

        public override void Defend()
        {
            Console.WriteLine("Evade attack for 10 seconds");
        }
    }
}

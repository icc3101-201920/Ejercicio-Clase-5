using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink: Armor
    {
        public Chainlink(): base() {}

        public override void Defend()
        {
            ArmorPoints = 100;
        }
    }
}

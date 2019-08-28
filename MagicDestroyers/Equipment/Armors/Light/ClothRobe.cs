using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe: Armor
    {
        public ClothRobe() :base()
        {

        }

        public override void Defend()
        {
            Console.WriteLine("Life points recover 10 per second");
        }
    }
}

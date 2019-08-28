using MagicDestroyers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor: IDefend
    {
        protected int DEFAULT_ARMOR_POINTS = 50;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }

        public Armor()
        {
            ArmorPoints = DEFAULT_ARMOR_POINTS;
        }

        public abstract void Defend();
    }
}

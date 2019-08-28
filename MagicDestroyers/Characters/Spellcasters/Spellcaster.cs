using MagicDestroyers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        protected const int DEFAULT_MANA_POINTS = 50;
        protected const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private int manaPoints;
        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
                }
            }
        }

        public Spellcaster() : this(DEFAULT_NAME, DEFAULT_LEVEL) { }
        public Spellcaster(string name, int level) : this(name, level, DEFAULT_HEALTHPOINT) { }

        public Spellcaster(string name, int level, int healthpoints) : base(name, level, healthpoints)
        {
            base.Faction = DEFAULT_FACTION;
            ManaPoints = DEFAULT_MANA_POINTS;
        }
    }
}

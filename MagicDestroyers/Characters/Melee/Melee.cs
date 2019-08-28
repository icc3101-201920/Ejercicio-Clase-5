using System;
using MagicDestroyers.Enums;


namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        protected const int DEFAULT_ABILTY_POINTS = 100;
        protected const Faction DEFAULT_FACTION = Faction.Melee;

        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
                }
            }
        }

        public Melee(): this(DEFAULT_NAME, DEFAULT_LEVEL) { }
        public Melee(string name, int level) : this(name,level, DEFAULT_HEALTHPOINT) { }

        public Melee(string name, int level, int healthpoints) : base(name, level, healthpoints)
        {
            base.Faction = DEFAULT_FACTION;
            AbilityPoints = DEFAULT_ABILTY_POINTS;
        }
    }
}

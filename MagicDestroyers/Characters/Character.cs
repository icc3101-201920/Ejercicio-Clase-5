using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        //DEFAULT VALUES
        protected const int DEFAULT_LEVEL = 1;
        protected const int DEFAULT_HEALTHPOINT = 100;
        protected const string DEFAULT_NAME = "Bob";


        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private Armor bodyArmor;
        private Weapon weapon;

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 120.");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public Character()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Character(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINT)
        {
        }

        public Character(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
        }

    
        public abstract void Attack();
        public abstract void SpecialAttack();
        public abstract void Defend();
        
    }
}

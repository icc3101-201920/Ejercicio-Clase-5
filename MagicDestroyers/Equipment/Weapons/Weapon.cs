using MagicDestroyers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon: IAttack
    {
        protected const int DEFAULT_DAMAGE_HAMMER = 50;
        protected const int DEFAULT_DAMAGE_SWORD = 30;
        protected const int DEFAULT_DAMAGE_STAFF = 10;
        protected const int DEFAULT_DAMAGE_AXE= 40;

        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage value should be a positive number");
                }
            }
        }

        public Weapon()
        {
        }

        public abstract void Attack();

        public abstract void SpecialAttack();
    }
}

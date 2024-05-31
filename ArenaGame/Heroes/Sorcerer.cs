using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Sorcerer : Hero
    {
        private int attackCounter;

        public Sorcerer(string name, double armor, double strength, IWeapon weapon)
            : base(name, armor, strength, weapon)
        {
            attackCounter = 0;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            attackCounter++;

            if (attackCounter == 3)
            {
                Weapon.HyperAbility(this, null);
                attackCounter = 0;
            }
            else
            {
                Weapon.SuperAbility(this, null);
            }

            return damage;
        }
    }
}
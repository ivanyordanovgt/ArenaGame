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
        private int superAbilityCounter;

        public Sorcerer(string name, double armor, double strength, IWeapon weapon)
            : base(name, armor, strength, weapon)
        {
            attackCounter = 0;
            superAbilityCounter = 0;
        }

        public override double Attack(Hero defender)
        {
            double damage = base.Attack();
            damage += this.weapon.AttackDamage
            attackCounter++;

            if (superAbilityCounter == 3)
            {
                Weapon.HyperAbility(this, defender);
                superAbilityCounter++;
            }
            if (attackCounter == 3) { }
            {
                Weapon.SuperAbility(this, defender);
                superAbilityCounter++;
                attackCounter = 0;
            }

            return damage;
        }
    }
}
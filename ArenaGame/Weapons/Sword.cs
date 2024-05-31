using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 2;
        }

        public void SuperAbility(Hero attacker, Hero defender)
        {
            // Sword deals extra damage
            defender.TakeDamage(15);
        }

        public void HyperAbility(Hero attacker, Hero defender)
        {
            // Sword deals massive extra damage
            defender.TakeDamage(40);
        }
    }
}
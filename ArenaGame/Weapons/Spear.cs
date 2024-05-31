using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Spear : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Spear(string name)
        {
            Name = name;
            AttackDamage = 45;
            BlockingPower = 4;
        }

        public void SuperAbility(Hero attacker, Hero defender)
        {
            // Spear ignores armor for this attack
            defender.TakeTrueDamage(20);
        }

        public void HyperAbility(Hero attacker, Hero defender)
        {
            // Spear deals massive true damage
            defender.TakeTrueDamage(50);
        }
    }
}
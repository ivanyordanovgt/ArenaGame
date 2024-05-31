using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 2;
        }

        public void SuperAbility(Hero attacker, Hero defender)
        {
            // Bow fires an extra arrow
            defender.TakeDamage(attacker.Attack());
        }

        public void HyperAbility(Hero attacker, Hero defender)
        {
            // Bow fires two extra arrows
            defender.TakeDamage(attacker.Attack());
            defender.TakeDamage(attacker.Attack());
        }
    }
}
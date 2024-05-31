using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Mace : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Mace(string name)
        {
            Name = name;
            AttackDamage = 35;
            BlockingPower = 3;
        }

        public void SuperAbility(Hero attacker, Hero defender)
        {
            // Mace reduces opponent's armor
            defender.ReduceArmor(10);
        }

        public void HyperAbility(Hero attacker, Hero defender)
        {
            // Mace greatly reduces opponent's armor
            defender.ReduceArmor(25);
        }
    }
}
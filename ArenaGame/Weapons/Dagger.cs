using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public void SuperAbility(Hero attacker, Hero defender)
        {
            // Dagger reduces opponent's armor
            defender.ReduceArmor(10);
        }

        public void HyperAbility(Hero attacker, Hero defender)
        {
            // Dagger greatly reduces opponent's armor
            defender.TakeTrueDamage(25);
        }
    }
}
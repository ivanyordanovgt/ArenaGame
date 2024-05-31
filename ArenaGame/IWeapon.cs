using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; }
        double BlockingPower { get; }
        void SuperAbility(Hero attacker, Hero defender);
        void HyperAbility(Hero attacker, Hero defender);
    }
}
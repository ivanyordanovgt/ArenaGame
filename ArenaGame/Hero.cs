// Hero.cs
using System;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Armor { get; private set; }
        public double Strenght { get; private set; }
        public IWeapon Weapon { get; private set; }
        private int attackCounter = 0;

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public Hero(string name, double armor, double strenght, IWeapon weapon)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
        }

        // returns actual damage
        public virtual double Attack(Hero defender)
        {
            double totalDamage = Strenght + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            attackCounter++;

            if (attackCounter % 3 == 0)
            {
                Weapon.HyperAbility(this, defender); // Hyper ability every third attack
            }
            else
            {
                Weapon.SuperAbility(this, defender); // Super ability otherwise
            }

            return realDamage;
        }

        public virtual double Defend(double damage)
        {
            double coef = random.Next(80, 120 + 1);
            double defendPower = (Armor + Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;
        }

        public void ReduceArmor(double amount)
        {
            Armor -= amount;
            if (Armor < 0) Armor = 0;
        }

        public void TakeTrueDamage(double amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }

        public void TakeDamage(double amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health, 2)}";
        }
    }
}

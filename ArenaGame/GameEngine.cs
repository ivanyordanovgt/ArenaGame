// GameEngine.cs
using System;

namespace ArenaGame
{
    public class GameEngine
    {
        public class NotificationArgs
        {
            public Hero Attacker { get; set; }
            public Hero Defender { get; set; }
            public double Attack { get; set; }
            public double Damage { get; set; }
        }

        public delegate void GameNotifications(NotificationArgs args);

        private Random random = new Random();
        public Hero HeroA { get; set; }
        public Hero HeroB { get; set; }
        public Hero Winner { get; set; }
        public GameNotifications? NotificationsCallBack { get; set; }
        public void Fight()
        {
            Hero attacker;
            Hero defender;

            double probability = random.NextDouble();
            if (probability < 0.5)
            {
                attacker = HeroA;
                defender = HeroB;
            }
            else
            {
                attacker = HeroB;
                defender = HeroA;
            }

            while (attacker.IsAlive && defender.IsAlive)
            {
                double attack = attacker.Attack();
                double actualDamage = defender.Defend(attack);

                NotificationsCallBack?.Invoke(new NotificationArgs()
                {
                    Attacker = attacker,
                    Defender = defender,
                    Attack = attack,
                    Damage = actualDamage
                });

                Hero tempHero = attacker;
                attacker = defender;
                defender = tempHero;
            }
            Winner = attacker.IsAlive ? attacker : defender;
        }
    }
}

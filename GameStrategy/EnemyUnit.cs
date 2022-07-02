
namespace GameStrategy
{
    public class EnemyUnit : IUnitAttack
    {
		public int Health;
        public int Damage;
        public int Survival;

		public EnemyUnit(int health, int damage, int survival)
		{
			Health = health;
			Damage = damage;
			Survival = survival;
		}

        public static void Attack()
        {
            Console.WriteLine("Enemy army casts a deadly spells...");
        }

        public override string ToString()
		{
			string unitInfo = $"Enemy unit : Health: {Health}, Damage: {Damage}, Survival: {Survival}";

			return unitInfo;
		}
	}
}

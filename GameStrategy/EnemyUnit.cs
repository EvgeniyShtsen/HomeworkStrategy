
namespace GameStrategy
{
    public class EnemyUnit
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

		public override string ToString()
		{
			string unitInfo = $"Enemy unit : Health: {Health}, Damage: {Damage}, Survival: {Survival}";

			return unitInfo;
		}
	}
}

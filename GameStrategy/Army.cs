namespace GameStrategy
{
	public abstract class Army
	{
		public static int CalculateTotalDamage(List<Unit> units)
		{
			int totalDamage = 0;
			foreach (Unit unit in units)
			{
				totalDamage += unit.Damage;
			}
			return totalDamage;
		}
		public static int CalculateTotalHealth(List<Unit> units)
		{
			int totalHealth = 0;
			foreach (Unit unit in units)
			{
				totalHealth += unit.Health + (unit.Survival*5);
			}
			return totalHealth;
		}
		public static int CalculateTotalSurvival(List<Unit> units)
		{
			int totalSurvival = 0;
			foreach (Unit unit in units)
			{
				totalSurvival += unit.Survival;
			}
			return totalSurvival;
		}
		public static long CalculateArmyCost(List<Unit> units)
		{
			long sum = 0;
			foreach (Unit unit in units)
			{
				sum = sum + unit.Cost;
			}
			return sum;
		}

		public static List<Unit> SortByDamage(List<Unit> units)
		{
			if (units.Count == 0)
			{
				Console.WriteLine("Nothing to sort");
			}

			units.Sort((unit1, unit2) => unit2.Damage.CompareTo(unit1.Damage));

			List<Unit> result = new List<Unit>();
			result.AddRange(units);
			return result;
		}

		public static List<Unit> SearchByHealthBar(List<Unit> units, int min, int max)
		{
			List<Unit> unitSelection = new List<Unit>();
			units.Sort((unit1, unit2) => unit1.Health.CompareTo(unit2.Health));

			foreach (Unit unit in units)
			{
				if (unit.Health >= min && unit.Health <= max)
				{
					unitSelection.Add(unit);
				}
			}
			return unitSelection;
		}

        public static int CalculateTotalHealth(List<EnemyUnit> enemyArmy)
        {
			int totalHealth = 0;
			foreach (EnemyUnit enemyUnit in enemyArmy)
			{
				totalHealth += enemyUnit.Health + (enemyUnit.Survival * 7);
			}
			return totalHealth;
		}

        public static int CalculateTotalDamage(List<EnemyUnit> enemyArmy)
        {
			int totalDamage = 0;
			foreach (EnemyUnit enemyUnit in enemyArmy)
			{
				totalDamage += enemyUnit.Damage;
			}
			return totalDamage;
		}

        public static int CalculateTotalSurvival(List<EnemyUnit> enemyArmy)
        {
			int totalSurvival = 0;
			foreach (EnemyUnit enemyUnit in enemyArmy)
			{
				totalSurvival += enemyUnit.Survival;
			}
			return totalSurvival;
		}
    }
}

using static GameStrategy.TypesAndRacesEnumFiles;

namespace GameStrategy
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<Unit> yourArmy = new List<Unit>
			{
				new MeleeTypeUnit (Race.Dwarf, 90, 50, 12, 5, MeleeType.Warrior, 100, 10),
				new RangeTypeUnit (Race.Furry, 105, 32, 14, 3, RangeType.Gunner, 40, 10),
				new MagicalTypeUnit (Race.Hobbit, 140, 40, 10, 2, MagicalType.Summoner, 140, 55),
			};
			
			Console.WriteLine("Your army: ");
			foreach (var unit in yourArmy)
			{
				Console.WriteLine(unit);
			}

			Console.WriteLine();
			Console.WriteLine($"Total health of your army: {Army.CalculateTotalHealth(yourArmy)}");
			Console.WriteLine($"Total damage of your army: {Army.CalculateTotalDamage(yourArmy)}");
			Console.WriteLine($"Overall survivability potential of your army: {Army.CalculateTotalSurvival(yourArmy)}");
			Console.WriteLine($"Army total cost is {Army.CalculateArmyCost(yourArmy)} coins");

			Console.WriteLine();
			Console.WriteLine("Sorting units by deal damage...");
			List<Unit> listByDealDamage = Army.SortByDamage(yourArmy);
			foreach (var unit in listByDealDamage)
			{
				Console.WriteLine(unit);
			}

			Console.WriteLine();
			Console.WriteLine("Searching units by health range...");
			List<Unit> unitsByHealth = Army.SearchByHealthBar(yourArmy, 20, 40);

			if (unitsByHealth.Count == 0)
			{
				Console.WriteLine("There are no units with defined maximum health");
			}
			else
			{
				foreach (Unit unit in unitsByHealth)
				{
					Console.WriteLine(unit);
				}
			}
			Console.WriteLine();
			Random rnd = new Random();
			List<EnemyUnit> enemyArmy = new List<EnemyUnit>

			{
				new EnemyUnit(rnd.Next(15,50),rnd.Next(5,25),rnd.Next(1, 10)),
				new EnemyUnit(rnd.Next(15,50),rnd.Next(5,25),rnd.Next(1, 10)),
				new EnemyUnit(rnd.Next(15,50),rnd.Next(5,25),rnd.Next(1, 10))
			};
			Console.WriteLine("Enemy army: ");
			foreach (var enemyUnit in enemyArmy)
			{
				Console.WriteLine(enemyUnit);
			}
			Console.WriteLine();
			Console.WriteLine($"Total health of enemy army: {Army.CalculateTotalHealth(enemyArmy)}");
			Console.WriteLine($"Total damage of enemy army: {Army.CalculateTotalDamage(enemyArmy)}");
			Console.WriteLine($"Overall survivability potential of enemy army: {Army.CalculateTotalSurvival(enemyArmy)}");
		}
	}
}



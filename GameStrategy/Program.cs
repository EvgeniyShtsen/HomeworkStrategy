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
			var yourArmyHealth = Army.CalculateTotalHealth(yourArmy);
			var yourArmyDamage = Army.CalculateTotalDamage(yourArmy);
			var yourArmySurvival = Army.CalculateTotalSurvival(yourArmy);
			Console.WriteLine();
			Console.WriteLine($"Total health of your army: {yourArmyHealth}");
			Console.WriteLine($"Total damage of your army: {yourArmyDamage}");
			Console.WriteLine($"Overall survivability potential of your army: {yourArmySurvival} (given bonus for max health +{yourArmySurvival*5})");
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
			var enemyHealth = Army.CalculateTotalHealth(enemyArmy);
			var enemyDamage = Army.CalculateTotalDamage(enemyArmy);
			var enemySurvival = Army.CalculateTotalSurvival(enemyArmy);

			Console.WriteLine();
			Console.WriteLine($"Total health of enemy army: {enemyHealth}");
			Console.WriteLine($"Total damage of enemy army: {enemyDamage}");
			Console.WriteLine($"Overall survivability potential of enemy army: {enemySurvival} (given bonus for max health +{enemySurvival*7})");
			Console.WriteLine();

			var yourArmyPotencial = yourArmyDamage + yourArmyHealth - enemySurvival;
			var emenyArmyPotencial = enemyDamage + enemyHealth - yourArmySurvival;
			Console.WriteLine();
			Console.WriteLine($"Total power of your army: {yourArmyPotencial}");
			Console.WriteLine($"Total power of your enemies: {emenyArmyPotencial}");
			Console.WriteLine("Lets battle!");
			Console.WriteLine();
			if (yourArmyPotencial > emenyArmyPotencial)
            {
				MeleeTypeUnit.Attack();
				RangeTypeUnit.Attack();
				MagicalTypeUnit.Attack();
				Console.WriteLine("YOU WON ALL ENEMIES!");
            }
            else
            {
				EnemyUnit.Attack();
				Console.WriteLine("Enemies have reduced your army to ashes :(");
				Console.WriteLine("Try Again...");
            }
		}
	}
}



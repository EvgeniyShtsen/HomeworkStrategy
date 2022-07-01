using static TypesAndRacesEnumFiles;

namespace GameStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
			List<Unit> army = new List<Unit>
			{
				new MeleeTypeUnit (Race.Dwarf, 90, 50, 12, 5, MeleeType.Warrior, 100, 10),
				new RangeTypeUnit (Race.Furry, 105, 32, 14, 3, RangeType.Gunner, 40, 10),
				new RangeTypeUnit (Race.Elf, 130, 20, 17, 3, RangeType.Archer, 30, 13),
				new MagicalTypeUnit (Race.Human, 200, 30, 20, 1, MagicalType.Wizard, 120, 65),
				new MeleeTypeUnit (Race.Orc, 170, 100, 18, 4, MeleeType.Berserker, 150, 13),
				new MagicalTypeUnit (Race.Hobbit, 140, 40, 10, 2, MagicalType.Summoner, 140, 55),
			};
			Console.WriteLine ("Your army: ");
			foreach (var unit in army)
            {
				Console.WriteLine (unit);
            }

			Console.WriteLine ();
			Console.WriteLine($"Total health of your army: {Army.CalculateTotalHealth(army)}");
			Console.WriteLine($"Total damage of your army: {Army.CalculateTotalDamage(army)}");
			Console.WriteLine($"Overall survivability potential of your army: {Army.CalculateTotalSurvival(army)}");
			Console.WriteLine($"Army total cost is {Army.CalculateArmyCost(army)} coins");

			Console.WriteLine ();
			Console.WriteLine("Sorting units by deal damage");
			List<Unit> listByDealDamage = Army.SortByDamage(army);
			foreach (var unit in listByDealDamage)
			{
				Console.WriteLine(unit);
			}

			Console.WriteLine();
			Console.WriteLine("Searching units by health range...");
			List<Unit> unitsByHealth = Army.SearchByHealthBar(army, 30, 50);

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
		}
    }
}
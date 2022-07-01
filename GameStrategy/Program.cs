using static TypesAndRacesEnumFiles;

namespace GameStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
			List<Unit> army = new List<Unit>
			{
				new MeleeTypeUnit (Race.Dwarf, 90, 50, 12, 5, 85, 1, 7, false, MeleeType.Warrior, 100, 10),
				new RangeTypeUnit (Race.Furry, 105, 32, 14, 3, 75, 12, 10, false, RangeType.Gunner, 40, 10),
				new RangeTypeUnit (Race.Elf, 130, 20, 17, 3, 70, 15, 12, false, RangeType.Archer, 30, 13),
				new MagicalTypeUnit (Race.Human, 200, 30, 20, 1, 15, 20, 15, true, MagicalType.Wizard, 120, 65),
				new MeleeTypeUnit (Race.Orc, 170, 100, 18, 4, 90, 2, 11, false, MeleeType.Berserker, 150, 13),
				new MagicalTypeUnit (Race.Hobbit, 140, 40, 10, 2, 20, 18, 15, false, MagicalType.Summoner, 140, 55),
			};

			Console.WriteLine("Calculating total army cost... ");
			long unitsCost = Army.CalculateArmyCost(army);
			Console.WriteLine($"Army total cost is {unitsCost} coins");

			Console.WriteLine();
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
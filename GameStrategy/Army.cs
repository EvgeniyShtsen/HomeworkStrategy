public class Army
{
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
}

using static TypesAndRacesEnumFiles;
public class RangeTypeUnit : Unit
{
	public RangeType RangeType { get; set; }

	public int Arrows { get; set; }
	public int BleedingChance { get; set; }

	public RangeTypeUnit(Race race, int cost, int health, int damage, int armor, int attackSpeed, int attackRange, int critChance, bool flying, RangeType rangeType, int arrows, int bleedingChance)
		: base(race, cost, health, damage, armor, attackSpeed, attackRange, critChance, flying)
	{
		RangeType = rangeType;
		Arrows = arrows;
		BleedingChance = bleedingChance;
	}
    public override string ToString()
	{
		return "Long Range Unit: " + $"Type: {RangeType}, " + base.ToString() + $", Stock of arrows: {Arrows}, Bleeding Chance: {BleedingChance}";
	}

}
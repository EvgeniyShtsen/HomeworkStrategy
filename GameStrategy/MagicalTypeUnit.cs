using static TypesAndRacesEnumFiles;
public class MagicalTypeUnit : Unit
{	
	public MagicalType MagicalType { set; get; }

	public int Mana { set; get; }
	public int CastSpeed { set; get; }

	public MagicalTypeUnit(Race race, int cost, int health, int damage, int armor, int attackSpeed, int attackRange, int critChance, bool flying, MagicalType magicalType, int mana, int castSpeed)
		: base(race, cost, health, damage, armor, attackSpeed, attackRange, critChance, flying)
	{
		MagicalType = magicalType;
		Mana = mana;
		CastSpeed = castSpeed;
	}
    public override string ToString()
	{
		return "Magical Unit: " + $"Type: {MagicalType}, " + base.ToString() + $", Mana: {Mana}, CastSpeed: {CastSpeed}";
	}
}
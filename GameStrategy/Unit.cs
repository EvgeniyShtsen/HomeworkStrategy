public class Unit
{
    public TypesAndRacesEnumFiles.Race Race { get; set; }
	public int Cost { get; set; }
	public int Health { get; set; }
	public int Damage { get; set; }
	public int Armor { get; set; }
	public int AttackSpeed { get; set; }
	public int AttackRange { get; set; }
	public int CritChance { get; set; }
	public bool Flying { get; set; }

	public Unit(TypesAndRacesEnumFiles.Race race, int cost, int health, int damage, int armor, int attackSpeed, int attackRange, int critChance, bool flying)
	{
        Race = race;
		Cost = cost;
		Health = health;
		Damage = damage;
		Armor = armor;
		AttackSpeed = attackSpeed;
		AttackRange = attackRange;
		CritChance = critChance;
		Flying = flying;
	}

	public override string ToString()
	{
		string unitInfo = $"Race: {Race}, Cost: {Cost}, Health: {Health}, Damage: {Damage}, Armor: {Armor}, Attack Speed: {AttackSpeed}, Attack Range: {AttackRange}, Crit Chance: {CritChance}";
		if (Flying == true)
		{
			unitInfo = unitInfo + ", Unit can fly";
		}
		else
		{
			unitInfo = unitInfo + ", Unit cannot fly";
		}
		return unitInfo;
	}
}
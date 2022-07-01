using static TypesAndRacesEnumFiles;
public class Unit
{
    public Race Race { get; set; }
	public int Cost { get; set; }
	public int Health { get; set; }
	public int Damage { get; set; }
	public int Survival { get; set; }
	

	public Unit(Race race, int cost, int health, int damage, int survival)
	{
        Race = race;
		Cost = cost;
		Health = health;
		Damage = damage;
		Survival = survival;
	}

	public override string ToString()
	{
		string unitInfo = $"Race: {Race}, Cost: {Cost}, Health: {Health}, Damage: {Damage}, Survival: {Survival}";

		return unitInfo;
	}
}
using static GameStrategy.TypesAndRacesEnumFiles;

namespace GameStrategy
{
	public class MeleeTypeUnit : Unit
	{
		public MeleeType MeleeType { get; set; }
		public int Stamina { get; set; }
		public int DoubleAttackChance { get; set; }

		public MeleeTypeUnit(Race race, int cost, int health, int damage, int survival, MeleeType meleeType, int stamina, int doubleAttackChance)
			: base(race, cost, health, damage, survival)
		{
			MeleeType = meleeType;
			Stamina = stamina;
			DoubleAttackChance = doubleAttackChance;
		}
		public override string ToString()
		{
			return "Melee unit: " + $"Type: {MeleeType}, " + base.ToString() + $", Stamina: {Stamina}, Double Attack Chance: {DoubleAttackChance}";
		}
	}
}
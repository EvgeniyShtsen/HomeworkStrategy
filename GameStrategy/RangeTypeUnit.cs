using static GameStrategy.TypesAndRacesEnumFiles;

namespace GameStrategy
{
	public class RangeTypeUnit : Unit, IUnitAttack
	{
		public RangeType RangeType { get; set; }
		public int Arrows { get; set; }
		public int BleedingChance { get; set; }

		public RangeTypeUnit(Race race, int cost, int health, int damage, int survival, RangeType rangeType, int arrows, int bleedingChance)
			: base(race, cost, health, damage, survival)
		{
			RangeType = rangeType;
			Arrows = arrows;
			BleedingChance = bleedingChance;
		}
		public override string ToString()
		{
			return "Range unit: " + $"Type: {RangeType}, " + base.ToString() + $", Stock of arrows: {Arrows}, Bleeding Chance: {BleedingChance}";
		}

        public static void Attack()
        {
            Console.WriteLine("Shooters actively flood enemies with a hail of arrows...");
        }
    }
}
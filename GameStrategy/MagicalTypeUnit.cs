using static GameStrategy.TypesAndRacesEnumFiles;

namespace GameStrategy
{
	public class MagicalTypeUnit : Unit
	{
		public MagicalType MagicalType { set; get; }
		public int Mana { set; get; }
		public int CastSpeed { set; get; }

		public MagicalTypeUnit(Race race, int cost, int health, int damage, int survival, MagicalType magicalType, int mana, int castSpeed)
			: base(race, cost, health, damage, survival)
		{
			MagicalType = magicalType;
			Mana = mana;
			CastSpeed = castSpeed;
		}
		public override string ToString()
		{
			return "Magical unit: " + $"Type: {MagicalType}, " + base.ToString() + $", Mana: {Mana}, CastSpeed: {CastSpeed}";
		}
	}
}
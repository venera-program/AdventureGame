namespace Player
{
	public interface IPlayer
	{
		DataLibrary.Room Location { get; set; }
		int Health { get; set; }
		void Fight(object target);
		int GetCurrentHealth();
		int GetMaxHealth();
		DataLibrary.Room GetLocation();
		void Move(Enums.CardinalDirection direction);
		void SetHealth(int newHealth);
		void SetLocation(DataLibrary.Room newLocation);
	}
}

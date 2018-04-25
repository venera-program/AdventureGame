using System.ComponentModel;
using System.Linq;
using Room = DataLibrary.Room;

namespace Player
{
	public abstract class Human : IPlayer
	{
		protected int health = 10;
		protected Room location;

		public Human(Room startPosition)
		{
			this.location = startPosition;
		}

		#region IPlayer Interface Implementation

		public virtual Room Location
		{
			get => GetLocation();
			set => SetLocation(value);
		}

		[DefaultValue(10)]
		public virtual int Health
		{
			get => GetCurrentHealth();
			set => SetHealth(value);
		}

		public virtual void Fight(object target) { }

		public virtual int GetCurrentHealth()
		{
			return this.health;
		}

		public virtual int GetMaxHealth()
		{
			int maxHealth = (int)((DefaultValueAttribute)TypeDescriptor
					.GetProperties(this)["Health"]
					.Attributes[typeof(DefaultValueAttribute)])
					.Value;

			return maxHealth;
		}

		public virtual Room GetLocation()
		{
			return this.location;
		}

		public virtual void Move(Enums.CardinalDirection direction)
		{
            Room destination = this.location.DoorList
				.Where(room => room.RelativeDirection == direction)
				.First()
				.ConnectedRoom;

			if (destination != null)
			{
				SetLocation(destination);
			}
		}

		public virtual void SetHealth(int newHealth)
		{
			this.health = newHealth;
		}

		public virtual void SetLocation(Room newLocation)
		{
			this.location = newLocation;
		}

		#endregion
	}
}

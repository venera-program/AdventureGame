using System.Collections.Generic;

namespace DataLibrary
{
	public class Room : IItemContainer
	{
		public struct Door
		{
			public Room LocalRoom { get; private set; }
			public Room ConnectedRoom { get; private set; }
			public Enums.CardinalDirection RelativeDirection { get; private set; }

			public Door(Room localRoom, Room connectedRoom, Enums.CardinalDirection relativeDirection)
			{
				this.LocalRoom = localRoom;
				this.ConnectedRoom = connectedRoom;
				this.RelativeDirection = relativeDirection;
			}
		}

		public List<Door> DoorList { get; private set; } = new List<Door>();
		public int RoomLength { get; private set; } = 1;
		public int RoomWidth { get; private set; } = 1;

        /// <summary>
		/// List of items contained in this class instance.
		/// </summary>
		private List<Item> ItemList { get; set; }

		/// <summary>
		/// Creates a room populated with a specified item.
		/// </summary>
		/// <param name="defaultItem"></param>
		public Room(Item defaultItem)
		{
			this.ItemList = new List<Item>();
			AddItem(defaultItem);
		}

		/// <summary>
		/// Creates a room populated with a specified list of items.
		/// </summary>
		/// <param name="defaultItems">A list of the items included by default
		/// in the room.</param>
		public Room(List<Item> defaultItems)
		{
			this.ItemList = new List<Item>();
			AddItems(defaultItems.ToArray());
		}

		// TODO: Procedural room generation/placement
		public Room(List<Item> defaultItems, int roomLength, int roomWidth)
		{
			AddItems(defaultItems.ToArray());
			this.RoomLength = roomLength;
			this.RoomWidth = roomWidth;
		}

		/// <summary>
		/// Adds a door which creates a connection relative to another room.
		/// </summary>
		/// <param name="connectingRoom">The room on the other side of the door.</param>
		/// <param name="directionToConnection">The relative direction towards the door
		/// from the center of the room.</param>
		public void AddDoor(Room connectingRoom, Enums.CardinalDirection directionToConnection)
		{
			this.DoorList.Add(new Door(this, connectingRoom, directionToConnection));
		}

		#region IItemContainer Interface Implementation


		/// <summary>
		/// Gets the items in item list.
		/// </summary>
		/// <returns> A list containing the items in ItemList. </returns>
		public List<Item> GetItems() { return this.ItemList; }

		/// <summary>
		/// Adds an item to the item list.
		/// </summary>
		/// <param name="itemToAdd"></param>
		public void AddItem(Item itemToAdd) { this.ItemList.Add(itemToAdd); }

		/// <summary>
		/// Adds multiple items to the item list.
		/// </summary>
		/// <param name="itemsToAdd"></param>
		public void AddItems(Item[] itemsToAdd) { this.ItemList.AddRange(itemsToAdd); }

		/// <summary>
		/// Removes all items from the item list with the specified name.
		/// </summary>
		/// <param name="itemName"></param>
		public void RemoveItem(string itemName)
		{
			this.ItemList.RemoveAll(item => item.ItemName == itemName);
		}

		#endregion
	}
}

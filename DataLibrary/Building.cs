using System.Collections.Generic;

namespace DataLibrary
{
	public class Building
	{
		public int BuildingLength { get; private set; }
		public int BuildingWidth { get; private set; }

		//TODO: Implement location with multidimensional (not jagged) array
		public List<Room> RoomList { get; private set; }

		/// <summary>
		/// Constructs a building with a specified length and width.
		/// </summary>
		/// <param name="lengthInUnits">The building's length in units.</param>
		/// <param name="widthInUnits">The building's width in units.</param>
		public Building(int lengthInUnits, int widthInUnits)
		{
			this.BuildingLength = lengthInUnits;
			this.BuildingWidth = widthInUnits;

			this.RoomList = new List<Room>(lengthInUnits * widthInUnits);
		}

		/// <summary>
		/// Adds a room to the building.
		/// </summary>
		/// <param name="newRoom">The room to be added.</param>
		public void AddRoom(Room newRoom)
		{
			if (this.RoomList.Contains(newRoom) == false)
			{
				this.RoomList.Add(newRoom);
			}
		}

		/// <summary>
		/// Removes a room from the building.
		/// </summary>
		/// <param name="roomToDelete">The room to be removed.</param>
		public void RemoveRoom(Room roomToDelete)
		{
			if (this.RoomList.Contains(roomToDelete))
			{
				this.RoomList.Remove(roomToDelete);
			}
		}
	}
}

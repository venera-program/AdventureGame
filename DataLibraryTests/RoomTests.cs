using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataLibrary.Tests
{
	[TestClass()]
	public class RoomTests
	{
		[TestMethod()]
		public void AddDoorTest()
		{
			var mainRoom = new Room(ItemPresets.BlackFluid);

			var northRoom = new Room(ItemPresets.BrokenMirror);
			var eastRoom = new Room(ItemPresets.ClothedSkeleton);
			var southRoom = new Room(ItemPresets.CopperCable);
			var westRoom = new Room(ItemPresets.FoodWrapper);

			int doorCount_BeforeDoorAdd = mainRoom.DoorList.Count;

			foreach (string cardinalDirection in System.Enum.GetNames(typeof(Enums.CardinalDirection)))
			{
				switch ((Enums.CardinalDirection)System.Enum.Parse(typeof(Enums.CardinalDirection), cardinalDirection))
				{
					case Enums.CardinalDirection.North:
						mainRoom.AddDoor(northRoom, Enums.CardinalDirection.North);
						break;
					case Enums.CardinalDirection.East:
						mainRoom.AddDoor(eastRoom, Enums.CardinalDirection.East);
						break;
					case Enums.CardinalDirection.South:
						mainRoom.AddDoor(southRoom, Enums.CardinalDirection.South);
						break;
					case Enums.CardinalDirection.West:
						mainRoom.AddDoor(westRoom, Enums.CardinalDirection.West);
						break;
					default:
						//TODO: Development log for unit test.
						Assert.Fail();
						break;
				}
			}

			int doorCount_AfterDoorAdd = mainRoom.DoorList.Count;

			try
			{
				Assert.AreNotEqual(doorCount_BeforeDoorAdd, doorCount_AfterDoorAdd);
			}
			catch (AssertFailedException)
			{
				//TODO: Development log for unit test.
				throw;
			}
		}
	}
}
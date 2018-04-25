using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataLibrary.Tests
{
	[TestClass()]
	public class BuildingTests
	{
		[TestMethod()]
		public void AddRoomTest()
		{
			var building1 = new Building(2, 1);
			var room1 = new Room(ItemPresets.BlackFluid);
			building1.AddRoom(room1);

			int listSize_OnStart = building1.RoomList.Count;

			var room2 = new Room(ItemPresets.BrokenMirror);
			building1.AddRoom(room2);

			int listSize_AfterAdd = building1.RoomList.Count;

			try
			{
				Assert.AreNotEqual(listSize_OnStart, listSize_AfterAdd);
			}
			catch (AssertFailedException)
			{
				//TODO: Development log for unit test.
				throw;
			}
		}

		[TestMethod()]
		public void RemoveRoomTest()
		{
			var building1 = new Building(2, 1);
			var room1 = new Room(ItemPresets.BlackFluid);
			building1.AddRoom(room1);

			int listSize_OnStart = building1.RoomList.Count;

			building1.RemoveRoom(room1);

			int listSize_AfterRemove = building1.RoomList.Count;

			try
			{
				Assert.AreNotEqual(listSize_OnStart, listSize_AfterRemove);
			}
			catch (AssertFailedException)
			{
				//TODO: Development log for unit test.
				throw;
			}
		}
	}
}
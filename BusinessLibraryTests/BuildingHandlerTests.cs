using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLibrary.Tests
{
    [TestClass()]
    public class BuildingHandlerTests
    {
        [TestMethod()]
        public void GetCurrentLocationTest()
        {
            DataLibrary.Room currentLocation = BuildingHandler.GetCurrentLocation();

            try
            {
                Assert.IsNotNull(currentLocation);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetItemNamesTest()
        {
            string[] itemNames = BuildingHandler.GetItemNames();

            try
            {
                Assert.IsNotNull(itemNames);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetItemDescriptionTest()
        {
            string itemName = BuildingHandler.GetItemNames()[0];
            string itemDescription = BuildingHandler.GetItemDescription(itemName);

            try
            {
                Assert.IsNotNull(itemDescription);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetItemsFromRoomTest()
        {
            DataLibrary.Item[] itemsList = BuildingHandler.GetItemsFromRoom(
                new DataLibrary.Room(DataLibrary.ItemPresets.BlackFluid),
                new DataLibrary.Character());

            try
            {
                Assert.IsNotNull(itemsList);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void HasDoorTest()
        {
            bool hasEastDoor = BuildingHandler.HasDoor(Enums.CardinalDirection.East);

            try
            {
                Assert.IsTrue(hasEastDoor);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void MovePlayerTest()
        {
            DataLibrary.Room startingLocation = BuildingHandler.GetCurrentLocation();

            IEnumerable<Enums.CardinalDirection> list = System.Enum.GetValues(typeof(Enums.CardinalDirection))
                .Cast<Enums.CardinalDirection>();

            if (list.Any((direction) => BuildingHandler.HasDoor(direction)))
            {
                Enums.CardinalDirection targetDirection = list
                    .Where((direction) => BuildingHandler.HasDoor(direction))
                    .First();

                BuildingHandler.MovePlayer(targetDirection);

                DataLibrary.Room endLocation = BuildingHandler.GetCurrentLocation();

                try
                {
                    Assert.AreNotEqual(startingLocation, endLocation);
                }
                catch (AssertFailedException)
                {
                    //TODO: Development log for unit test.
                    throw;
                }
            }
            else
            {
                try
                {
                    Assert.Fail();
                }
                catch (AssertFailedException)
                {
                    //TODO: Development log for unit test.
                    throw;
                }
            }
        }

        [TestMethod()]
        public void SearchForItemTypeTest()
        {
            var itemsList = new List<DataLibrary.Item>
            {
                DataLibrary.ItemPresets.CopperCable,
                DataLibrary.ItemPresets.OldLighter,
                DataLibrary.ItemPresets.RustedKey
            };

            bool hasItem = BuildingHandler.SearchForItemType(itemsList, Enums.ItemType.LightSource);

            try
            {
                Assert.IsTrue(hasItem);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void ResetPlayerLocationTest()
        {
            DataLibrary.Room startingLocation = BuildingHandler.GetCurrentLocation();

            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);

            DataLibrary.Room endLocation = BuildingHandler.GetCurrentLocation();

            BuildingHandler.ResetPlayerLocation();

            try
            {
                Assert.AreNotEqual(startingLocation, endLocation);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }
    }
}
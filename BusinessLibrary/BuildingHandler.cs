using System.Collections.Generic;
using System.Linq;

namespace BusinessLibrary
{
    public static class BuildingHandler
    {
        /// <summary>
        /// The building being managed and referenced.
        /// </summary>
        private static DataLibrary.Building mainBuilding;

        /// <summary>
        /// Automatically generates a building.
        /// </summary>
        static BuildingHandler()
        {
            //TODO: Dynamic building sizing/population
            mainBuilding = new DataLibrary.Building(2, 4);

            PopulateRooms();
            GenerateDoors();

            CombatHandler.activePlayer = new Player.BladeRunner(mainBuilding.RoomList[0]);
        }

        /// <summary>
        /// Populates the room list in the building.
        /// </summary>
        private static void PopulateRooms()
        {
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.RobotParts));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.FoodWrapper));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.OldLighter));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.BrokenMirror));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.CopperCable));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.ClothedSkeleton));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.RustedKey));
            mainBuilding.AddRoom(new DataLibrary.Room(DataLibrary.ItemPresets.BlackFluid));

            CombatHandler.enemyList.Add(new Player.Replicant(mainBuilding.RoomList[3]));
            CombatHandler.enemyList.Add(new Player.Replicant(mainBuilding.RoomList[6]));
        }

        /// <summary>
        /// Generates doors for each of the eight rooms.
        /// </summary>
        private static void GenerateDoors()
        {
            // Building Structure:
            //
            // Start
            //  vvv
            // -----------------
            // | 0 | 1 | 2 | 3 |
            // -----------------
            // | 4 | 5 | 6 | 7 |
            // -----------------
            //

            //--Top 4 rooms
            //Add doors to room at index = 0
            mainBuilding.RoomList[0].AddDoor(mainBuilding.RoomList[1], Enums.CardinalDirection.East);
            mainBuilding.RoomList[0].AddDoor(mainBuilding.RoomList[4], Enums.CardinalDirection.South);


            //Add doors to rooms at index = 1, 2
            for (int i = 1; i < 3; i++)
            {
                mainBuilding.RoomList[i].AddDoor(mainBuilding.RoomList[i - 1], Enums.CardinalDirection.West);
                mainBuilding.RoomList[i].AddDoor(mainBuilding.RoomList[i + 1], Enums.CardinalDirection.East);
                mainBuilding.RoomList[i].AddDoor(mainBuilding.RoomList[i + 4], Enums.CardinalDirection.South);
            }

            //Add doors to room at index = 3
            mainBuilding.RoomList[3].AddDoor(mainBuilding.RoomList[2], Enums.CardinalDirection.West);
            mainBuilding.RoomList[3].AddDoor(mainBuilding.RoomList[7], Enums.CardinalDirection.South);

            //--Bottom 4 rooms
            //Add doors to room at index = 4
            mainBuilding.RoomList[4].AddDoor(mainBuilding.RoomList[5], Enums.CardinalDirection.East);
            mainBuilding.RoomList[4].AddDoor(mainBuilding.RoomList[0], Enums.CardinalDirection.North);

            //Add doors to rooms at index = 5, 6
            for (int i = 5; i < 7; i++)
            {
                mainBuilding.RoomList[i].AddDoor(mainBuilding.RoomList[i - 4], Enums.CardinalDirection.North);
                mainBuilding.RoomList[i].AddDoor(mainBuilding.RoomList[i - 1], Enums.CardinalDirection.West);
                mainBuilding.RoomList[i].AddDoor(mainBuilding.RoomList[i + 1], Enums.CardinalDirection.East);
            }

            //Add doors to room at index = 7
            mainBuilding.RoomList[7].AddDoor(mainBuilding.RoomList[6], Enums.CardinalDirection.West);
            mainBuilding.RoomList[7].AddDoor(mainBuilding.RoomList[3], Enums.CardinalDirection.North);
        }

        /// <summary>
        /// Gets a list of the items present in the current active room.
        /// </summary>
        /// <returns>Returns an array of strings which contains all items in the current room.</returns>
        public static string[] GetItemNames()
        {
            try
            {
                return CombatHandler.activePlayer.GetLocation().GetItems()
                        .Select(item => item.ItemName)
                        .ToArray();
            }
            catch (System.NullReferenceException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
        }

        /// <summary>
        /// Gets the description for a specified item.
        /// </summary>
        /// <param name="itemName">The item of the name being looked up.</param>
        /// <returns>Returns a string equal to a specified item's description.</returns>
        public static string GetItemDescription(string itemName)
        {
            try
            {
                return CombatHandler.activePlayer.GetLocation().GetItems()
                    .First(item => item.ItemName == itemName)
                    .ItemDescription;
            }
            catch (System.NullReferenceException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
        }

        /// <summary>
        /// Searches in a specified room with a specified character and returns the items visible to that character. 
        /// </summary>
        /// <param name="room">The room to be searched for available items.</param>
        /// <param name="character">The character that is searching the room.</param>
        /// <returns>Returns an array that holds all items visible to 'character'.</returns>
        public static DataLibrary.Item[] GetItemsFromRoom(DataLibrary.Room room, DataLibrary.Character character)
        {
            //TODO: Implement item requirements
            List<DataLibrary.Item> availableTools = character.GetTools();

            try
            {
                if (availableTools != null)
                {
                    return room.GetItems()
                        .Where(item => SearchForItemType(availableTools, item.SearchRequirement) == true)
                        .Select(item => item)
                        .ToArray();
                }

                return room.GetItems().ToArray();
            }
            catch (System.NullReferenceException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
        }

        public static DataLibrary.Room GetCurrentLocation()
        {
            return CombatHandler.activePlayer.GetLocation();
        }

        /// <summary>
        /// Checks the current room for an Eastern door
        /// </summary>
        /// <returns>Returns true if the current room has an Eastern door.</returns>
        public static bool HasDoor(Enums.CardinalDirection direction)
        {
            try
            {
                return CombatHandler.activePlayer.GetLocation().DoorList
                    .Any(door => door.RelativeDirection == direction);
            }
            catch (System.NullReferenceException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
        }

        /// <summary>
        /// Moves the active player in the chosen direction.
        /// </summary>
        /// <param name="direction">Direction to move towards.</param>
        public static void MovePlayer(Enums.CardinalDirection direction)
        {
            switch (direction)
            {
                case Enums.CardinalDirection.North:
                    if (HasDoor(Enums.CardinalDirection.North))
                    {
                        CombatHandler.activePlayer.Move(Enums.CardinalDirection.North);
                    }
                    break;
                case Enums.CardinalDirection.South:
                    if (HasDoor(Enums.CardinalDirection.South))
                    {
                        CombatHandler.activePlayer.Move(Enums.CardinalDirection.South);
                    }
                    break;
                case Enums.CardinalDirection.East:
                    if (HasDoor(Enums.CardinalDirection.East))
                    {
                        CombatHandler.activePlayer.Move(Enums.CardinalDirection.East);
                    }
                    break;
                case Enums.CardinalDirection.West:
                    if (HasDoor(Enums.CardinalDirection.West))
                    {
                        CombatHandler.activePlayer.Move(Enums.CardinalDirection.West);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void ResetPlayerLocation()
        {
            CombatHandler.activePlayer.SetLocation(mainBuilding.RoomList[0]);
        }

        /// <summary>
        /// Searches a list of items for any item that is of a chosen item type.
        /// </summary>
        /// <param name="targetItems">The list of items to be searched.</param>
        /// <param name="targetType">The target item type to look for during the search.</param>
        /// <returns>Returns true if an item of the chosen type is found during the search.</returns>
        public static bool SearchForItemType(List<DataLibrary.Item> targetItems, Enums.ItemType targetType)
        {
            return targetItems
                .Any(item => item.SearchRequirement == targetType);
        }
    }
}

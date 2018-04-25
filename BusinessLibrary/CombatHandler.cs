using System.Collections.Generic;
using System.Linq;

namespace BusinessLibrary
{
    public static class CombatHandler
    {
        /// <summary>
        /// The active player to be referenced.
        /// </summary>
        internal static Player.Human activePlayer;

        /// <summary>
        /// A list of the enemies in the building, regardless of location.
        /// </summary>
        internal static List<Player.AI> enemyList = new List<Player.AI>();

        /// <summary>
        /// Checks if there are any enemies in the same room as the active player's current location.
        /// </summary>
        /// <returns>Returns true if there are enemies with the same location as the current player.</returns>
        public static bool EnemyIsPresent()
        {
            DataLibrary.Room currentRoom = activePlayer.GetLocation();

            try
            {
                return enemyList.Any((enemy) => enemy.GetLocation() == currentRoom);
            }
            catch (System.NullReferenceException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
        }

        /// <summary>
        /// Gets the current health of the enemy in the current room (one enemy per room).
        /// </summary>
        /// <returns>Returns an integer equal to the enemy's current health.</returns>
        public static int GetEnemyCurrentHealth()
        {
            DataLibrary.Room currentRoom = activePlayer.GetLocation();

            try
            {
                Player.AI enemyInRoom = enemyList
                .Where(enemy => enemy.GetLocation() == currentRoom)
                .First();

                return enemyInRoom.GetCurrentHealth();
            }
            catch (System.InvalidOperationException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
            catch (System.NullReferenceException)
            {
                //TODO: Log exception for development reference. (Structure error)
                throw;
            }
        }

        /// <summary>
        /// Gets the maximum health of the enemy in the current room (one enemy per room).
        /// </summary>
        /// <returns>Returns an integer equal to the enemy's maximum health.</returns>
        public static int GetEnemyMaxHealth()
        {
            DataLibrary.Room currentRoom = activePlayer.GetLocation();

            Player.AI enemyInRoom = enemyList
                .Where(enemy => enemy.GetLocation() == currentRoom)
                .First();

            return enemyInRoom.GetMaxHealth();
        }


        /// <summary>
        /// Gets the current health of the active player.
        /// </summary>
        /// <returns>Returns an integer equal to the player's current health.</returns>
        public static int GetPlayerCurrentHealth()
        {
            return activePlayer.GetCurrentHealth();
        }

        /// <summary>
        /// Gets the maximum health of the active player.
        /// </summary>
        /// <returns>Returns an integer equal to the player's maximum health.</returns>
        public static int GetPlayerMaxHealth()
        {
            return activePlayer.GetMaxHealth();
        }

        /// <summary>
        /// Automatically simulates one full round of turn-based combat.
        /// </summary>
        public static void TakeCombatTurn()
        {
            //Variable that references enemy in room without recurring searches
            Player.AI enemyInRoom = enemyList
                .Where(enemy => enemy.GetLocation() == activePlayer.GetLocation())
                .First();

            //Player attacks enemy in room
            activePlayer.Fight(enemyInRoom);

            //if: enemy is still alive
            if (enemyInRoom.GetCurrentHealth() > 0)
            {
                //Enemy attacks player
                enemyInRoom.Fight(activePlayer);
            }

            //Remove all dead enemies
            enemyList.RemoveAll(enemy => enemy.GetCurrentHealth() <= 0);
        }
    }
}

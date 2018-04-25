using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLibrary.Tests
{
    [TestClass()]
    public class CombatHandlerTests
    {
        [TestMethod()]
        public void EnemyIsPresentTest()
        {
            BuildingHandler.ResetPlayerLocation();

            //Move to room index 2 (which contains an enemy)
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);

            bool roomContainsEnemy = CombatHandler.EnemyIsPresent();

            try
            {
                Assert.IsTrue(roomContainsEnemy);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetEnemyCurrentHealthTest()
        {
            BuildingHandler.ResetPlayerLocation();

            //Move to room index 2 (which contains an enemy)
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);

            int enemyCurrentHealth = CombatHandler.GetEnemyCurrentHealth();

            try
            {
                Assert.AreNotEqual(0, enemyCurrentHealth);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetEnemyMaxHealthTest()
        {
            BuildingHandler.ResetPlayerLocation();

            //Move to room index 2 (which contains an enemy)
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);

            int enemyMaxHealth = CombatHandler.GetEnemyMaxHealth();

            try
            {
                Assert.AreNotEqual(0, enemyMaxHealth);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetPlayerCurrentHealthTest()
        {
            int playerCurrentHealth = CombatHandler.GetPlayerCurrentHealth();

            try
            {
                Assert.AreNotEqual(0, playerCurrentHealth);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void GetPlayerMaxHealthTest()
        {
            int playerMaxHealth = CombatHandler.GetPlayerMaxHealth();

            try
            {
                Assert.AreNotEqual(0, playerMaxHealth);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void TakeCombatTurnTest()
        {
            BuildingHandler.ResetPlayerLocation();

            //Move to room index 2 (which contains an enemy)
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);

            int playerMaxHealth = CombatHandler.GetPlayerMaxHealth();

            CombatHandler.TakeCombatTurn();

            try
            {
                Assert.AreNotEqual(0, playerMaxHealth);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                Assert.Fail();
            }
        }
    }
}
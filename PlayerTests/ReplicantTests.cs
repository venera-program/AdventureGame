using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Player.Tests
{
    [TestClass()]
    public class ReplicantTests
    {
        [TestMethod()]
        public void FightTest()
        {
            var room1 = new DataLibrary.Room(DataLibrary.ItemPresets.BlackFluid);
            var human = new BladeRunner(room1);
            var ai = new Replicant(room1);
            int aiStartingHealth = ai.GetMaxHealth();
            int aiPostCombatHealth;

            human.Fight(ai);

            aiPostCombatHealth = ai.GetCurrentHealth();

            try
            {
                Assert.AreNotEqual(aiStartingHealth, aiPostCombatHealth);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                throw;
            }
        }

        [TestMethod()]
        public void MoveTest()
        {
            var room1 = new DataLibrary.Room(DataLibrary.ItemPresets.BlackFluid);
            var room2 = new DataLibrary.Room(DataLibrary.ItemPresets.BrokenMirror);
            room1.AddDoor(room2, Enums.CardinalDirection.East);

            var replicant = new Replicant(room1);
            DataLibrary.Room startingLocation = replicant.GetLocation();

            replicant.Move(Enums.CardinalDirection.East);

            DataLibrary.Room endLocation = replicant.GetLocation();

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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataLibrary.Tests
{
    [TestClass()]
    public class CharacterTests
    {
        [TestMethod()]
        public void GetToolsTest()
        {
            var toolsList = new List<Item>();
            var character1 = new Character();
            Item item1 = ItemPresets.OldLighter;

            character1.AddItem(item1);

            int toolsCount_OnStart = toolsList.Count;

            toolsList = character1.GetTools();

            int toolsCount_AfterAddTool = toolsList.Count;

            try
            {
                Assert.AreNotEqual(toolsCount_OnStart, toolsCount_AfterAddTool);
            }
            catch (AssertFailedException)
            {
                //TODO: Development log for unit test.
                Assert.Fail();
            }
        }
    }
}
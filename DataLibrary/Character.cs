using System.Collections.Generic;
using System.Linq;

namespace DataLibrary
{
    //TODO: Implement Character into Player
    public class Character : IItemContainer
    {
        /// <summary>
        /// List of items contained in this class instance.
        /// </summary>
        private List<Item> ItemList { get; set; } = new List<Item>();

        public List<Item> GetTools()
        {
            if (this.ItemList == null)
            {
                return null;
            }

            return (this.ItemList
                    .Where(item => item.ItemType != Enums.ItemType.None))
                    .ToList();
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

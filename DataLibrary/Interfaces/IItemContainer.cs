using System.Collections.Generic;

namespace DataLibrary
{
	interface IItemContainer
	{
		List<Item> GetItems();
		void AddItem(Item itemToAdd);
		void AddItems(Item[] itemsToAdd);
		void RemoveItem(string itemName);
	}
}

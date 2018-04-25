namespace DataLibrary
{
	public class Item
	{
		public string ItemName { get; private set; }
		public string ItemDescription { get; private set; }
		public Enums.ItemType ItemType { get; private set; } = Enums.ItemType.None;
		public Enums.ItemType SearchRequirement { get; private set; } = Enums.ItemType.None;

		/// <summary>
		/// Creates an item that has a non-specific type and is not implicitly hidden.
		/// </summary>
		/// <param name="itemName"></param>
		/// <param name="itemDescription"></param>
		public Item(string itemName, string itemDescription)
		{
			this.ItemName = itemName;
			this.ItemDescription = itemDescription;
		}

		/// <summary>
		/// Creates an item that can be a specific type and can be implicitly hidden.
		/// </summary>
		/// <param name="itemName"></param>
		/// <param name="itemType"></param>
		/// <param name="itemDescription"></param>
		public Item(string itemName, string itemDescription, Enums.ItemType itemType,
			Enums.ItemType searchRequirement)
		{
			this.ItemName = itemName;
			this.ItemDescription = itemDescription;
			this.ItemType = itemType;
			this.SearchRequirement = searchRequirement;
		}
	}
}

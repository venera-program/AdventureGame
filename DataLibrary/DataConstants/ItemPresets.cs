namespace DataLibrary
{
	/// <summary>
	/// Provides pre-built items to be used with room generation.
	/// </summary>
	public static class ItemPresets
	{
		//Item ctor template:
		// - Item Name
		// - Item Description
		// - Item Type (optional)
		// - Search Requirement (optional)

		public static Item RobotParts = new Item(
			"Broken Robot Parts",
			"A bunch of metal scraps with no apparent source.");

		public static Item FoodWrapper = new Item(
			"Old Food Wrapper",
			"The plastic remnants of a delicious meal.");

		public static Item OldLighter = new Item(
			"Old-Fashioned Lighter",
			"Fueled by butane. Although primitive, still gets the job done.",
			Enums.ItemType.LightSource,
			Enums.ItemType.None);

		public static Item BrokenMirror = new Item(
			"Broken Mirror",
			"Some would call it an omen, but it's just some broken glass at the end of the day.",
			Enums.ItemType.None,
			Enums.ItemType.LightSource);

		public static Item CopperCable = new Item(
			"Dangling Copper Cable",
			"A long electrical cable stripped to its core, who knows if it's still getting power.");

		public static Item ClothedSkeleton = new Item(
			"Clothed Skeleton",
			"The tragic remains of a once loyal resident.");

		public static Item RustedKey = new Item(
			"Rusted Key",
			"A key so rusted you couldn't use it if you tried.",
			Enums.ItemType.None,
			Enums.ItemType.LightSource);

		public static Item BlackFluid = new Item(
			"Puddle of Black Fluid",
			"Judging by the glistening surface, it's probably flammable. Better to stay away.");
	}
}

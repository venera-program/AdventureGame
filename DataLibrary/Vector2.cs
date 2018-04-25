namespace DataLibrary
{
	public class Vector2
	{
		public static Vector2 Zero = new Vector2(0, 0);

		/// <summary>
		/// The x value of the vector.
		/// </summary>
		public int x;
		/// <summary>
		/// The y value of the vector.
		/// </summary>
		public int y;

		/// <summary>
		/// Creates a two-dimensional vector with specified coordinates.
		/// </summary>
		/// <param name="x">The x value of the vector.</param>
		/// <param name="y">The y value of the vector.</param>
		public Vector2(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}

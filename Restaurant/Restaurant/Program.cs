using System;

namespace Restaurant
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var restaurant = new Restaurant ("Ngozi", "Awka", 2.5);

			restaurant.GenerateReceipt ();
		}
	}
}

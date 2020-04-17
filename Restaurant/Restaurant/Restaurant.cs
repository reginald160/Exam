using System;

namespace Restaurant
{
	public class Restaurant
	{
		private string name  { get; set; }

		private string address  { get; set; }

		private double gratuity;

		public Restaurant (string name, string address, double gratuity)
		{
			this.name = name;
			this.address = address;
			this.gratuity = gratuity;
		}

		public double Gratuity {

			get{ return this.gratuity; }
			set {
				if (value > 0) {
					gratuity = value;
				
				}
			}


		}

		public void GenerateReceipt ()
		{
			double temp = 0;
			int i = 1;
			while (i > 0) {

				Console.WriteLine ("Enter the price of item:" + i);
				double price = Convert.ToDouble (Console.ReadLine ());

					
					
			      temp += i;
					Console.WriteLine ("The subtotal gratuity is " + temp);
				
				}




				if (price == -1) {
					break;
				}

				i++;

			}



		}

	}

}
}


using System;

namespace Rectangle
{
	public class Rectangle
	{
		public readonly float length = 1.0f;

		public readonly float width = 1.0f;



		public Rectangle (float length, float width)
		{

			this.length = length;

			this.width = width;

		}


		public float Length {

			get{ return this.length; }

			set { 
				if ((value > 0.0) && (value < 20.0)) {

					this.length = value;
				} 
			}
		}

		public float Width {

			get{ return this.width; }

			set { 
				if ((value > 0.0) && (value < 20.0)) {

					this.width = value;
				} 
			}
		}

		public float Area ()
		{

			return  Width * Length; 

		}



	}
}



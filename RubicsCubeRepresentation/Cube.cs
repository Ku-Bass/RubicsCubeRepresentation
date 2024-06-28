using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicsCubeRepresentation
{
	internal class Cube
	{
		//colors of the cube
		public static int yellow = 1; //top
		public static int green = 2; //front
		public static int orange = 3; //right
		public static int red = 4; //left
		public static int blue = 5; //back
		public static int white = 6;//down

		//sides of the cube
		int[] yellowSide { get; }
		int[] greenSide { get; }
		int[] orangeSide { get; }
		int[] redSide { get; }
		int[] blueSide { get; }
		int[] whiteSide { get; }

		//constructor for a custom starting scramble
		public Cube(int[] yellowS, int[] greenS, int[] orangeS, int[] redS, int[] blueS, int[] whiteS)
		{// if all the parameters have a length of 8

			if (yellowS.Length == 8 && greenS.Length == 8 && orangeS.Length == 8 &&
			redS.Length == 8 && blueS.Length == 8 && whiteS.Length == 8)
			{
				yellowSide = yellowS;
				greenSide = greenS;
				orangeSide = orangeS;
				redSide = redS;
				blueSide = blueS;
				whiteSide = whiteS;
			}



		}


		//default constructor for a solved cube
		public Cube()
		{
			yellowSide = new int[]
	   {

 Cube.yellow, Cube.yellow, Cube.yellow, Cube.yellow, Cube.yellow, Cube.yellow, Cube.yellow, Cube.yellow
	   };
			greenSide = new int[]
		   {

Cube.green, Cube.green, Cube.green, Cube.green,Cube.green,Cube.green,Cube.green,Cube.green,
		   };
			orangeSide = new int[]
			{

Cube.orange,Cube.orange,Cube.orange,Cube.orange,Cube.orange,Cube.orange,Cube.orange,Cube.orange,

			};
			redSide = new int[]
			{
Cube.red,Cube.red,Cube.red,Cube.red,Cube.red,Cube.red,Cube.red,Cube.red,
			};
			blueSide = new int[]
			 {
Cube.blue,Cube.blue,Cube.blue,Cube.blue,Cube.blue,Cube.blue,Cube.blue,Cube.blue,
			 };
			whiteSide = new int[]
			{
Cube.white, Cube.white,Cube.white,Cube.white,Cube.white,Cube.white,Cube.white,Cube.white,
			};
		}

		//helper methods for making moves
		List<int[]> ChangeThree(int[] front, int[] top, int[] back, int[] down, int a1, int a2, int a3, int b1, int b2, int b3, int c1, int c2, int c3, int d1, int d2, int d3)
		{
			int store1 = 0;
			int store2 = 0;
			int store3 = 0;

			store1 = top[b1];
			store2 = top[b2];
			store3 = top[b3];

			top[b1] = front[a1];
			top[b2] = front[a2];
			top[b3] = front[a3];

			front[a1] = down[d1];
			front[a2] = down[d2];
			front[a3] = down[d3];

			down[d1] = back[c1];
			down[d2] = back[c2];
			down[d3] = back[c3];

			back[c1] = store1;
			back[c2] = store2;
			back[c3] = store3;

			List<int[]> final = new List<int[]>() { front, top, down, back };
			return final;
		}
		//methods for making moves (imagine that the green side is facing you and the white is facing up)
		public void R()
		{
			SpiralClockwise(orangeSide);

			ChangeThree(greenSide, yellowSide, blueSide, whiteSide, 2, 3, 4, 2, 3, 4, 2, 3, 4, 2, 3, 4);
			// souřadnice píšu odshora dolů vždy o číslo menší protože 0 based index.
		}
		public void RPrime()
		{
			SpiralCounterClockwise(orangeSide);

			ChangeThree(blueSide, yellowSide, greenSide, whiteSide, 2, 3, 4, 2, 3, 4, 2, 3, 4, 2, 3, 4);
			// souřadnice u prime opačně
		}
		public void L()
		{
			SpiralClockwise(redSide);
			ChangeThree(blueSide, yellowSide, greenSide, whiteSide, 0, 7, 6, 0, 7, 6, 0, 7, 6, 0, 7, 6);

		}
		public void LPrime()
		{
			SpiralClockwise(redSide);
			ChangeThree(greenSide, yellowSide, blueSide, whiteSide, 0, 7, 6, 0, 7, 6, 0, 7, 6, 0, 7, 6);

		}
		public void U()
		{
			SpiralClockwise(yellowSide);
			ChangeThree(greenSide, redSide, blueSide, orangeSide, 0, 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 0);
		}
		public void UPrime()
		{
			SpiralCounterClockwise(yellowSide);
			ChangeThree(blueSide, redSide, greenSide, orangeSide, 4, 5, 6, 2, 3, 4, 0, 1, 2, 6, 7, 0);
		}
		public void D()
		{
			SpiralClockwise(whiteSide);
			ChangeThree(blueSide, redSide, greenSide, orangeSide, 0, 1, 2, 6, 7, 0, 4, 5, 6, 2, 3, 4);
		}
		public void DPrime()
		{
			SpiralCounterClockwise(whiteSide);
			ChangeThree(greenSide, redSide, blueSide, orangeSide, 4, 5, 6, 6, 7, 0, 0, 1, 2, 2, 3, 4);
		}
		public void F()
		{
			SpiralClockwise(greenSide);
			ChangeThree(redSide, yellowSide, orangeSide, whiteSide, 4, 5, 6, 4, 5, 6, 4, 5, 6, 0, 1, 2);
		}
		public void FPrime()
		{
			SpiralCounterClockwise(greenSide);
			ChangeThree(orangeSide, yellowSide, redSide, whiteSide, 4, 5, 6, 4, 5, 6, 4, 5, 6, 0, 1, 2);
		}
		public void B()
		{
			SpiralClockwise(blueSide);
			ChangeThree(orangeSide, yellowSide, redSide, whiteSide, 0, 1, 2, 0, 1, 2, 0, 1, 2, 4, 5, 6);
		}
		public void BPrime()
		{
			SpiralCounterClockwise(blueSide);
			ChangeThree(redSide, yellowSide, orangeSide, whiteSide, 0, 1, 2, 0, 1, 2, 0, 1, 2, 4, 5, 6);
		}
		int[] SpiralClockwise(int[] side)
		{
			for (int j = 0; j < 2; j++)
			{
				int store = side.Last();
				for (int i = 0; i < side.Length; i++)
				{
					int store2 = side[i];
					side[i] = store;
					store = store2;


				}
			}
			return side;
		}

		int[] SpiralCounterClockwise(int[] side)
		{
			for (int j = 0; j < 2; j++)
			{
				int store = side.First();
				for (int i = side.Length - 1; i >= 0; i--)
				{
					int store2 = side[i];
					side[i] = store;
					store = store2;


				}
			}
			return side;
		}
	}

}

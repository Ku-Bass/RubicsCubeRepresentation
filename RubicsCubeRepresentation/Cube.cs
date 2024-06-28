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
		//method for copiing a cube into another instance of the RubicsCube class
		public Cube CloneCube()
		{
			int[] yellowSideN = new int[8];
			int[] greenSideN = new int[8];
			int[] orangeSideN = new int[8];
			int[] redSideN = new int[8];
			int[] blueSideN = new int[8];
			int[] whiteSideN = new int[8];

			System.Array.Copy(yellowSide, yellowSideN, yellowSide.Length);
			System.Array.Copy(greenSide, greenSideN, greenSide.Length);
			System.Array.Copy(orangeSide, orangeSideN, orangeSide.Length);
			System.Array.Copy(redSide, redSideN, redSide.Length);
			System.Array.Copy(blueSide, blueSideN, blueSide.Length);
			System.Array.Copy(whiteSide, whiteSideN, whiteSide.Length);

			return new Cube(yellowSideN, greenSideN, orangeSideN, redSideN, blueSideN, whiteSideN);

		}

		//method for getting the position of the cube in a single array
		public int[] GetPositionArray()
		{
			int[] output = new int[48];
			yellowSide.CopyTo(output, 0);

			greenSide.CopyTo(output, 8);
			orangeSide.CopyTo(output, 16);
			redSide.CopyTo(output, 24);
			blueSide.CopyTo(output, 32);
			whiteSide.CopyTo(output, 40);
			return output;
		}


		// method for scrambling the cube with a given number of random moves
		public void Scramble(int moves)
		{
			for (int i = 0; i < moves; i++)
			{
				RandomMove();
			}
		}

		//makes one random move
		public void RandomMove()
		{
			int rng = Random.Shared.Next(1, 12);
			switch (rng)
			{
				case 1:
					{
						R();
						//path += "R ";
						break;
					}
				case 2:
					{
						RPrime();
						//path += "R' ";
						break;
					}
				case 3:
					{
						L();
						//path += "L ";
						break;
					}
				case 4:
					{
						LPrime();
						//path += "L' ";
						break;
					}
				case 5:
					{
						U();
						//path += "U ";
						break;
					}
				case 6:
					{
						UPrime();
						//path += "U' ";
						break;
					}
				case 7:
					{
						D();
						//path += "D ";
						break;
					}
				case 8:
					{
						DPrime();
						//path += "D' ";
						break;
					}
				case 9:
					{
						F();
						//path += "F ";
						break;
					}
				case 10:
					{
						FPrime();
						//path += "F' ";
						break;
					}
				case 11:
					{
						B();
						// path += "B ";
						break;
					}
				case 12:
					{
						BPrime();
						// path += "B' ";
						break;
					}
			}
		}


		//method for making a specific move
		/*
		 * 1 = R
		 * 2 = R'
		 * 3 = L
		 * 4 = L'
		 * 5 = U
		 * 6 = U'
		 * 7 = D
		 * 8 = D'
		 * 9 = F
		 * 10 = F'
		 * 11 = B
		 * 12 = B'
		 * */
		public void Move(int move)
		{

			switch (move)
			{
				case 1:
					{
						R();
						//path += "R ";
						break;
					}
				case 2:
					{
						RPrime();
						//path += "R' ";
						break;
					}
				case 3:
					{
						L();
						//path += "L ";
						break;
					}
				case 4:
					{
						LPrime();
						//path += "L' ";
						break;
					}
				case 5:
					{
						U();
						//path += "U ";
						break;
					}
				case 6:
					{
						UPrime();
						//path += "U' ";
						break;
					}
				case 7:
					{
						D();
						//path += "D ";
						break;
					}
				case 8:
					{
						DPrime();
						//path += "D' ";
						break;
					}
				case 9:
					{
						F();
						//path += "F ";
						break;
					}
				case 10:
					{
						FPrime();
						//path += "F' ";
						break;
					}
				case 11:
					{
						B();
						// path += "B ";
						break;
					}
				case 12:
					{
						BPrime();
						// path += "B' ";
						break;
					}
			}
		}

		//method for checking if the cube is solved (returns true if solved)
		public bool Solved()
		{

			if (CheckIfSame(yellowSide) == false || CheckIfSame(greenSide) == false || CheckIfSame(orangeSide) == false || CheckIfSame(redSide) == false || CheckIfSame(blueSide) == false || CheckIfSame(whiteSide) == false)
			{
				return false;
			}
			else return true;
		}

		//method for checking how many squares have correct colors (solved cube = 48)
		public int HowCloseAmI()
		{
			int counter = 0;
			counter += CheckHowMuchCorrect(yellowSide);
			counter += CheckHowMuchCorrect(greenSide);
			counter += CheckHowMuchCorrect(orangeSide);
			counter += CheckHowMuchCorrect(redSide);
			counter += CheckHowMuchCorrect(blueSide);
			counter += CheckHowMuchCorrect(whiteSide);
			return counter;
		}

		//method for checking if a side is solved
		bool CheckIfSame(int[] side)
		{
			int control = 0;
			if (side == yellowSide)
			{
				control = Cube.yellow;
			}
			else if (side == greenSide)
			{
				control = Cube.green;
			}
			else if (side == orangeSide)
			{
				control = Cube.orange;
			}
			else if (side == redSide)
			{
				control = Cube.red;
			}
			else if (side == blueSide)
			{
				control = Cube.blue;
			}
			else if (side == whiteSide)
			{
				control = Cube.white;
			}
			foreach (int i in side)
			{
				if (i != control)
				{
					return false;
				}
			}

			return true;
		}

		//helper method for checking how many squares have correct colors on a side
		int CheckHowMuchCorrect(int[] side)
		{
			int counter = 0;
			int control = 0;
			if (side == yellowSide)
			{
				control = Cube.yellow;
			}
			else if (side == greenSide)
			{
				control = Cube.green;
			}
			else if (side == orangeSide)
			{
				control = Cube.orange;
			}
			else if (side == redSide)
			{
				control = Cube.red;
			}
			else if (side == blueSide)
			{
				control = Cube.blue;
			}
			else if (side == whiteSide)
			{
				control = Cube.white;
			}
			foreach (int i in side)
			{
				if (i == control)
				{
					counter++;
				}
			}

			return counter;
		}

		//helper method for printing  a side of the cube in console
		void Print(int[] a)
		{
			foreach (int i in a)
			{
				Console.WriteLine(i);
			}
		}

		//method for printing the whole cube in console
		public void PrintCube()
		{
			Console.WriteLine("yellow");
			Print(yellowSide);
			Console.WriteLine("green");
			Print(greenSide);
			Console.WriteLine("orange");
			Print(orangeSide);
			Console.WriteLine("red");
			Print(redSide);
			Console.WriteLine("blue");
			Print(blueSide);
			Console.WriteLine("white");
			Print(whiteSide);
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

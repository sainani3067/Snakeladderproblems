using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_LadderProblems
{
    class UC6_DiceProblem
	{ 
		
			public static int NUMBER_OF_P = 1;
			public static int P_SCORE = 0;
			public static int rollDice;
			public static int count = 0;
			public static void Main(String[] args)
			{
				//Loop to check Player position =100
				while (P_SCORE != 100)
				{
					getRoll();//calling function for rolling dice
					optionPlay();// calling function to check the optionPlay
					if (P_SCORE > 100)
					{
						P_SCORE = P_SCORE - rollDice;
					}
				}
				Console.WriteLine("Number of dice rolls is " + count);
			}

			//Method for Rolling Dice
			public static int getRoll()
			{
				Random rNumber = new Random();
				rollDice = rNumber.Next(1, 7);
				count++;//Count the number of time die is roll
				return rollDice;
			}

			//Method to check for Option Play
			public static void optionPlay()
			{
				Random opNumber = new Random();
				int optionNum = (opNumber.Next(0, 3));

				if (optionNum == 2)
				{
					P_SCORE = P_SCORE + rollDice;
					Console.WriteLine("Player position after getting Ladder: " + P_SCORE);
				}
				else if (optionNum == 1)
				{
					P_SCORE = P_SCORE - rollDice;
					if (P_SCORE < 0)
					{
						P_SCORE = 0;
					}
					Console.WriteLine("Player position after getting Snake: " + P_SCORE);
				}
				else
				{
					Console.WriteLine("Player position for No Play " + P_SCORE);
				}
			}
		}
	}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_projectLucky_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String playAgain;
            do
            {             ////ask the user for a starting number for the lowest number in the number range//
                Console.WriteLine("Today's jackpot is 200k! What is your lowest in the number range?");
                int lowNum = int.Parse(Console.ReadLine());

                ////ask the user max number in the range

                Console.WriteLine("What is the highest number in the range?");
                int HighNum = int.Parse(Console.ReadLine());

                //// ask the user to gues the 6 numbers the user thinks will be the lucky numbers within the range//
                
                //int i;
                int[] luckyNum = new int[6];

                for (int i = 0; i < luckyNum.Length; i++)

                {
                    Console.WriteLine("Nice! Please choose six lucky numbers, one at time. Press 'ENTER' after each number?");
                    luckyNum[i] = int.Parse(Console.ReadLine());

                    while (luckyNum[i] < lowNum || luckyNum[i] > HighNum)
                    {
                        Console.WriteLine("Please enter valid number within your range.");
                        luckyNum[i] = int.Parse(Console.ReadLine());
                    }

                }

                    int[] winNum = new int[6];
                    Random compareNum = new Random();


                    for (int j = 0; j < luckyNum.Length; j++)
                    {
                        winNum[j] = compareNum.Next(lowNum, HighNum);
                        Console.WriteLine("lucky numbers: " + winNum[j]);
                    }

                int matchNum = 0;

                for (int i = 0; i < luckyNum.Length; i++)
                {
                    for (int j = 0; j < winNum.Length; j++)
                    {
                        if (luckyNum[i] == winNum[j])
                        {
                            matchNum++;

                        }
                    }
                }


                

                Console.WriteLine("You guessed " + matchNum + " numbers correctly!");

                int jackpot = 200000;
               
                if (matchNum == 6)
                { 
                    Console.WriteLine("Congrats! You hit jackpot! You have won  $" + jackpot / 6 * 6);
                }

                else if (matchNum == 5)
                {
                    Console.WriteLine("Lucky for you. you win $" + jackpot / 6 * 5);
                }
                else if (matchNum == 4)
                {
                    Console.WriteLine("You win $" + jackpot / 6 * 4);
                }
                else if (matchNum == 3)
                {
                    Console.WriteLine("Your prize is $" + jackpot / 6 * 3);
                }

                else if (matchNum == 2)
                {
                    Console.WriteLine("Congrats you win  $" + jackpot / 6 * 2);
                }

                else if (matchNum == 1)
                {
                    Console.WriteLine("You win  $" + jackpot / 6 * 1);
                }

                else
                {
                    Console.WriteLine("Sorry. You didn't match any numbers at this time.");

                }

                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine().ToLower();
            }

            while (playAgain == "yes");
            while (playAgain == "no")
            { Console.WriteLine("Thanks for playing!");
                break;
            }


        }
    }
}






















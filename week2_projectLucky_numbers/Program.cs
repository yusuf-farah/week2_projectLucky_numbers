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
            ////ask the user for a starting number for the lowest number in the number range//
            Console.WriteLine(" what is your lowest in the number range?");//
            int userMinNum = int.Parse(Console.ReadLine());

            ////ask the user max number in the range

            Console.WriteLine("what is the highest number in the range?");
            int userMaxNum = int.Parse(Console.ReadLine());

            //// ask the user to gues the 6 numbers the user thinks will be the lucky numbers within the range//
            Console.WriteLine(" nice please choose six lucky numbers?");
            int i = int.Parse(Console.Console.Readline());
            int[] luckyNum = new int[6];

            for (int i = 0; i < luckyNum.Length; i++)
            {
                luckyNum[i] = int.Parse(Console.ReadLine());
                
            }

            if (luckyNum[i] < userMinNum || luckyNum[i] > userMaxNum)
            {
                Console.WriteLine("please enter valid number");
                --luckyNum[i];
            }


            int[] winNum = new int[6];

            Random rand = new Random();


            for (int j = 0; j < winNum.Length; j++)
            {
                int winNumumbers = rand.Next(userMinNum, userMaxNum) + 1;

                winNum[j] = winNumumbers;

            }
            foreach (int m in winNum)
            {
                Console.WriteLine("lucky Number  " + m);
            }


            int jackAmount = 20000;
            int guesNum = 0;

            for (int i = 0; i < luckyNum.Length)
                for (int j = 0; j < winNum.Length)
                {
                    guesNum++;
                }
            if (guesNum == 6)
            {
                Console.WriteLine(" you win" + jackAmount);
            }
            else if (guesNum == 5)
            {
                Console.WriteLine("you win " + (5 / 6) * jackAmount);
            }
            else if (guesNum == 4)
            {
                {
                    Console.WriteLine("you win " + (4 / 6) * jackAmount);
                }
                else(guesNum == 3)
                    {
                    Console.WriteLine("you win " + (3 / 6);
                }
                Console.WriteLine(" Do you want to play again");
                playAgain = Console.ReadLine();
            }

            while (playAgain == "yes") ;


        }
    }
}






















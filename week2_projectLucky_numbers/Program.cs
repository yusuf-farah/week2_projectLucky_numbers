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

            ////ask the user for a starting number for the lowest number in the number range//
            Console.WriteLine(" what is your lowest in the number range?");//
            int userMinNum = int.Parse(Console.ReadLine());

            ////ask the user max number in the range

            Console.WriteLine("what is the highest number in the range?");
            int userMaxNum = int.Parse(Console.ReadLine());

            //// ask the user to gues the 6 numbers the user thinks will be the lucky numbers within the range//
            Console.WriteLine(" nice please choose six lucky numbers?");

            int[] guesNum = new int[6];

            for (int i = 0; i < guesNum.Length; i++)
            {
                guesNum[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(guesNum[i]);
            }
            if (guesNum[i] < userMinNum || guesNum[i] > userMaxNum)
            {
                Console.WriteLine("please enter valid number");
                Console.ReadKey();


                }

            Random rando = new Random();
            Console.WriteLine(rando.Next(userMinNum, userMaxNum));






        

    }


    }
      }



    














            



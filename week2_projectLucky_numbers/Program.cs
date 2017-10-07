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
            //vairables

            //ask the user for a starting number for the lowest number in the number range//
            Console.WriteLine("what is your lowest in the number range?");//
            int userminNum = int.Parse(Console.ReadLine());

            //ask the user max number in the range

            Console.WriteLine("what is the highest number in the range?");
            int usermaxNum = int.Parse(Console.ReadLine());

            // ask the user to gues the 6 numbers the user thinks will be the lucky numbers within the range//
            //Console.WriteLine(" nice please choose six lucky numbers?");


            int[] guesNum = new int[6];

            for (int i = 0; i < guesNum.Length; i++)

                if (guesNum[i]>userminNum && guesNum[i]< usermaxNum +1)
                {
                    Console.WriteLine(" valid number");
                    Console.Write("please continue");
                    break;
                }
                else   
                {
                    Console.WriteLine("oops!  invalid ");
                }
                         
                int[] randomGeneratorNum = new int[6];
                Random rand = new Random();
            int randomNumber = rand.Next();
            

                for (int i = 0; <guesNum.Length; i++)
                {
                if (j = 0 ; i<randomGeneratorNum.Length);
                    {

                    }
                     randomNumber = rand.Next(userminNum, usermaxNum) + 1;
                   
                    Console.WriteLine("luckyNumbers", j);


                }
               




            }

            }
        }
    

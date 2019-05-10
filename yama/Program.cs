using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        private static object arr;

        static void Main(string[] args)
        {
              
             string steps = Console.ReadLine();
             string[] arr = steps.Split(' ');

            Console.WriteLine("Yamalarin sayi :" + volleys(arr).ToString());
            Console.ReadKey();
        }

        static int volleys(string [] voll)
        {
            int level = 0;
            bool inVolley = false;
            int vollCount = 0;

            // U D D U D D D U D U U U U D D U D U
            for (int i = 0; i < voll.Length; i++)
            {
                if (voll[i] == "U") { level++; }
                else { level--; }

                if(level < 0)
                {
                    inVolley = true;
                }
                else if(level == 0 && inVolley == true)
                {
                    vollCount++;
                    inVolley = false; 
                }

            }
            return vollCount;
        }
    }
}

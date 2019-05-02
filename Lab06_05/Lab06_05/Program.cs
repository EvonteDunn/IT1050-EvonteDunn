using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumber = new int[1000];
            Random random = new Random();


            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100);
            }


            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());
                Console.ReadLine();

           



            }
        }

     }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
                Console.ReadLine();
            }
        }
    }
}

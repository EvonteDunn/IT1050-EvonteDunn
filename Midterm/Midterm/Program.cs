using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 11)

                    keepLooping = false;
                i++;
                Console.WriteLine(i);


            }

        }
    }
}



//1.
//Different control structures we use are loops, if statements and switch statements.Loops such as while, do while and for will repeat a fragment of code until the terminating sequence is met.If statements, if else and else statements use logic to solve code, and switch statements can be used in replacement of if else statements.


//8.
//We combine multiple Boolean values by nested if or if else statements. Three primary operators that we use when working with multiple Boolean values are: ||, &&, and !.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                        Console.ReadLine();
                    }
                }
            }
        }
    }

}





//1.
//A)Control variable - A variable used to control the number of times a set of statements will execute
//B)Initial value – The starting value assigned to the control variable
//C)The increment/decrement – Modifies the control variable in either an increase or a decrease during the loop
//D)The loop-continuation condition - Determines whether to continue looping.

//2.As long as a loop-continuation condition remains true, the While and For repetition statements both will repeatedly execute a statement or set of statements. The while and for repetition statements both also implement their bodies zero or more times. The control variable in a While statement is usually initialized before the loop and is incremented within the loop's body. 

//3. It would be useful to utilize a do-while statement when something needs to occur, but it won't occur correctly with certainty on the first iteration. The loop will always run at least once with a do-while statement, so if it is preferred that a condition be checked at the end of the loop execution it will verify if it should iterate further.

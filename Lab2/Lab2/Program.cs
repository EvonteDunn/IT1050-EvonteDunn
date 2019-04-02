using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World\tFrom Evonte");

            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer");

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer");

            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 * number2;

            Console.WriteLine("Sum is {0}", sum);
            Console.Read();


            //A. You execute your program after building it by pressing the Ctrl+F5 buttons.
            //B. Floating point variables store only approximations of real numbers across a greater range of values whereas an integer variable store a limited range of real numbers precisely.
            //C. “DisplayMessage” is a method from chapter 4
            //D.  Get, Set

            //E.  Classes are declared to create objects. Classes are created to house a method, which are used to perform the classes tasks. Objects are created in classes to actually help execute or perform the classes functions.











        }
    }
}
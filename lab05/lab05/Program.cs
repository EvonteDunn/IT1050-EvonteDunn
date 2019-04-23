using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            

          //1.
            //a.Scope-scope of a variable defines where it can be used in an app. In the example above scope is the entire body of the method. The scope of a method, property or field of a class is the entire body.

            // b.Static vs. Non - Static – static is not written into the example above(ie.Public static void Main(string[] args) however the use of “public” is where you should see static written and used in the example above.Static methods can call only other static methods of the same class by using the method name by itself and can only manipulate other static variables in the same class.

            //c.Return Type -3 different return types, the one used in this example uses the actual word “return”  with height * width afterwards. The other 2 return types are void and a return expression.

            //d.Method Name (Identifier) – getArea is the method name used in this example.Although most times a Method Name starts with an Uppercase letter.

            //e.Parameters – in the example above, the method is calling on the height and width results, which are the parameters. Parameters are the additional information that a method needs to perform its task

            //f.Method Body – contains statements that perform the method’s tasks. Begins with and ends with { }. Method completes once the declared task has been perform and given the return result, if one was need(ie as long as void wasn’t used)



            //2.

            //A user-defined method is a method that is written in an app that allow us to modularize it by separating its tasks into self-contained units. The statements are only written once, can be reused from several locations in an app and are hidden from other methods. 


            //3.
            //Static methods can call only other static methods of the same class by using the method name by itself and can only manipulate other static variables in the same class. Static methods relate to a class as a whole. Non-static methods are associated with a specific instance or object of the class and may manipulate the instance variables o that object. 















            // To do: uncomment the following lines of code to call the methods
            // myDog.bark();
            // myDog.doTrick("Fetch");
        }
    }
}

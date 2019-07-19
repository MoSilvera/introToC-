using System;
using System.Collections.Generic;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Not only do you have to say what type the variable is, you also
    have to instantiate that exact same type of object on assignment.
    This may seem redundant, but it's part of the C# language compiler's
    type checking constraints.
*/
            List<string> products = new List<string>() {
                    "Motorcycle",
                    "Sofa",
                    "Sandals",
                    "Omega Watch",
                    "iPhone",
                };

            /*
                A foreach loop is used to iterate over a collection.

                The code below is roughly equivalent to the following JavaScript:
                products.forEach(product => {
                    console.log(product);
                });
            */
            foreach (string product in products)
            {
                Console.WriteLine(product);
            }

            /*
                Like JavaScript, C# has a for() loop

                This code is equivalent to the foreach loop above.
            */
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
            }

            foreach (string product in products) {
    if (product.Length < 5) {
        Console.WriteLine($"{product} has a short name");
    } else if (product.Length < 10) {
        Console.WriteLine($"{product} has a medium-sized name");
    } else {
        Console.WriteLine($"{product} has a long name");
    }
}
        }
    }
}
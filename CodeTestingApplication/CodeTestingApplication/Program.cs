using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic test = "test";

            test += " 123";

            Console.WriteLine(test);

            test = 1;

            test += 1;

            Console.WriteLine(test);

            test += "23";

            Console.WriteLine(test);

            test = Convert.ToInt32(test);

            Console.WriteLine(test);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}

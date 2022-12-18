using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hakan.ParameterizedThread.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first parameter: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second parameter: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Parameters parameters = new Parameters(x, y);

            // Parameterized Thread Start needs to take an object and the method should be void.
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(parameters);
            Console.ReadLine();
        }

        static void Add (object data)
        {
            if (data is Parameters)
            {
                Console.WriteLine("Id of thread in main(): {0}", Thread.CurrentThread.ManagedThreadId);
                Parameters parameters = (Parameters)data;
                Console.WriteLine("{0} + {1} = {2}", parameters.a, parameters.b, parameters.a+parameters.b);
            }
        }
    }

    class Parameters
    {
        public int a;
        public int b;


        public Parameters(int num1, int num2)
        {
            a = num1;
            b = num2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Bidule b1 = Bidule.GetInstance();
            Bidule b2 = Bidule.GetInstance();

            Console.WriteLine(b1.Equals(b2));  
             Console.WriteLine("Essai de modification depuis Github");

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}

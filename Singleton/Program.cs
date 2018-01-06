using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparer comparer = Comparer.GetComparerInstance();
            Console.WriteLine("Is string equals " + comparer.IsStringEquals("as","as").ToString());
            Console.WriteLine("Is string equals " + comparer.IsStringEquals("asd", "dsa").ToString());
            
            Console.ReadKey();

            AnotherComparision();
        }
        private static void AnotherComparision()
        {
            Comparer comparer = Comparer.GetComparerInstance();
            Console.WriteLine("What about this strings? Are they equals? " + comparer.IsStringEquals("qwe", "qwe").ToString());
            Console.ReadKey();
        }
    }
}

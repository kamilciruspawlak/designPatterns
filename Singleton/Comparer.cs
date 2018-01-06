using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Comparer  // klasa musi byc publiczna (o globalnym zasiegu)
    {
        static Comparer comparer = null;

        private Comparer() // prywatny konstruktor sprawia ze moze byc tylko jedna instancja, ktora wywolujemy przez GetComparerInstance, nigdzie poza ta klasa nie mozna uzyc "new Comparer"
        {
        }

        public static Comparer GetComparerInstance()
        {
            if (comparer == null)
            {
                Comparer comparer = new Comparer();
                return comparer;
            }
            return comparer;
        }

        public bool IsStringEquals(string string1, string string2)
        {
            return string1.Equals(string2);
        }
    }
}

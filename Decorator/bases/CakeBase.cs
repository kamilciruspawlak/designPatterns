using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class CakeBase : BakeryComponent // Nasza "podstawa", obiekty tej klasy będą mogły być "dekorowane"
    {
        private string _Name = "Cake base, ";
        private double _Cost = 200.0;

        public override double Cost()
        {
            return _Cost;
        }

        public override string Name()
        {
            return _Name;
        }
    }
    
} 

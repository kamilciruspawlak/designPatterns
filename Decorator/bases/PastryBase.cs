using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class PastryBase : BakeryComponent // kolejna podstawa, patrz CakeBase
    {
        private string _Name = "Pastry base, ";
        private double _Price = 38.0;

        public override double Cost()
        {
            return _Price;
        }

        public override string Name()
        {
            return _Name;
        }
    }
}

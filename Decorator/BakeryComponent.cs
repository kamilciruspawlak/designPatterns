using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class BakeryComponent // klasa abstrakcyjna po ktorej dziedziczyc beda wszystkie obiekty i dekoratory
    {
        public abstract string Name();
        public abstract double Cost();

        public void DescribeYourself()
        {
            Console.WriteLine("Components: " + this.Name() + Environment.NewLine + "Cost: " + this.Cost());
        }

    }
}

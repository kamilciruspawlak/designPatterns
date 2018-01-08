using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.docorators
{
    public class RaspberriesDecorator : BakeryComponent  // Dekorator dziedziczy po Bakery Component 
    {
        BakeryComponent bakeryComponent;                      // a takze zawiera w sobie Bakery Component

        public RaspberriesDecorator(BakeryComponent b)
        {
            this.bakeryComponent = b;
        }

        public override double Cost()
        {
            return this.bakeryComponent.Cost() + 4;
        }

        public override string Name()
        {
            return this.bakeryComponent.Name() + "raspberries on top, ";
        }
    }
}

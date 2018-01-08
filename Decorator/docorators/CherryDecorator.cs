using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.docorators
{
    class CherryDecorator : BakeryComponent
    {
        BakeryComponent bakeryComponent;

        public CherryDecorator(BakeryComponent b)
        {
            this.bakeryComponent = b;
        }

        public override double Cost()
        {
            return this.bakeryComponent.Cost() + 666;
        }

        public override string Name()
        {
            return this.bakeryComponent.Name() + "chery's on top";
        }
    }
}

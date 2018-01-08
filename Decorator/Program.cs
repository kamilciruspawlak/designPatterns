using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.docorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var CheryPie = new CherryDecorator(new CakeBase());
            CheryPie.DescribeYourself();


            var TurboPie = new CherryDecorator(new RaspberriesDecorator(new PastryBase()));
            TurboPie.DescribeYourself();


            Console.ReadKey();

        }
    }
}

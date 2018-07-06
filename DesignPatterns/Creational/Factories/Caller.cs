using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Creational.Factories.AbstractClass;
using static DesignPatterns.Creational.Factories.Method;

namespace DesignPatterns.Creational.Factories
{
    class Caller
    {
        public static void Method()
        {
            var p1 = new Point(2, 3, Point.CoordinateSystem.Cartesian);
            var origin = Point.Origin;

            var p2 = Point.Factory.NewCartesianPoint(1, 2);
        }

        public static void AbstractClass()
        {
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}

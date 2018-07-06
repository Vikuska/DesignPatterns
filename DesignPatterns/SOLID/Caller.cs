using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.SOLID.DependencyInversion;
using static DesignPatterns.SOLID.LiskovSubstition;

namespace DesignPatterns.SOLID
{
    public class Caller : Core.CWrite
    {
        public static void SingleResponsibility()
        {
            var j = new SingleRespinsibility.Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");
            Console.WriteLine(j);
            //WriteLine(j);

            var p = new SingleRespinsibility.Persistence();
            var filename = @"c:\temp\journal.txt";
            p.SaveToFile(j, filename);
            System.Diagnostics.Process.Start(filename);
        }

        public static void OpenClosed()
        {
            var apple = new OpenClosed.Product("Apple", DesignPatterns.SOLID.OpenClosed.Color.Green, DesignPatterns.SOLID.OpenClosed.Size.Small);
            var tree = new OpenClosed.Product("Tree", DesignPatterns.SOLID.OpenClosed.Color.Green, DesignPatterns.SOLID.OpenClosed.Size.Large);
            var house = new OpenClosed.Product("House", DesignPatterns.SOLID.OpenClosed.Color.Blue, DesignPatterns.SOLID.OpenClosed.Size.Large);

            OpenClosed.Product[] products = { apple, tree, house };

            var pf = new OpenClosed.ProductFilter();
            WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColor(products, DesignPatterns.SOLID.OpenClosed.Color.Green))
                WriteLine($" - {p.Name} is green");

            // ^^ BEFORE

            // vv AFTER
            var bf = new OpenClosed.BetterFilter();
            WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new OpenClosed.ColorSpecification(DesignPatterns.SOLID.OpenClosed.Color.Green)))
                WriteLine($" - {p.Name} is green");

            WriteLine("Large products");
            foreach (var p in bf.Filter(products, new OpenClosed.SizeSpecification(DesignPatterns.SOLID.OpenClosed.Size.Large)))
                WriteLine($" - {p.Name} is large");

            WriteLine("Large blue items");
            foreach (var p in bf.Filter(products,
              new OpenClosed.AndSpecification<OpenClosed.Product>(new OpenClosed.ColorSpecification(DesignPatterns.SOLID.OpenClosed.Color.Blue), new OpenClosed.SizeSpecification(DesignPatterns.SOLID.OpenClosed.Size.Large)))
            )
            {
                WriteLine($" - {p.Name} is big and blue");
            }
        }

        // public static int Area(Rectangle r) => r.Width * r.Height;
        // static public int Area(Rectangle r) => r.Width * r.Height;   -- from origin
        public static void LiskovSubstition()
        {
            int Area(Rectangle r) => r.Width * r.Height;

                Rectangle rc = new Rectangle(2, 3);
                WriteLine($"{rc} has area {Area(rc)}");

                // should be able to substitute a base type for a subtype
                /*Square*/
                Rectangle sq = new Square();
                sq.Width = 4;
                WriteLine($"{sq} has area {Area(sq)}");
        }

        public static void DependencyInversion()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Matt" };

            // low-level module
            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);

            WriteLine(relationships.ToString());
        }
    }
}

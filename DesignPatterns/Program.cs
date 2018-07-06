using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.SOLID.LiskovSubstition;
//using static DesignPatterns.SOLID.LiskovSubstition;

namespace DesignPatterns
{
    class Program
    {
        static public int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            SOLID.Caller.SingleResponsibility();
            SOLID.Caller.OpenClosed();
            SOLID.Caller.LiskovSubstition();
            SOLID.Caller.DependencyInversion();

            Creational.Builder.Caller.Builder();
            Creational.Builder.Caller.BuilderFacets();

            Creational.Factories.Caller.Method();
            Creational.Factories.Caller.AbstractClass();

            Creational.Prototype.Caller.ICloneableIsBad();
            Creational.Prototype.Caller.CopyConstructors();
            Creational.Prototype.Caller.CopyThroughSerialization();

            Creational.Singleton.Caller.Implementation();
            Creational.Singleton.Caller.InDependencyInjection();
            Creational.Singleton.Caller.Monostate();

            Console.ReadLine();
        }
    }
}

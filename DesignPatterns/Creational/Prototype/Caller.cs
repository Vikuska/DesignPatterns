using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.Prototype.Bad;
using static System.Console;

namespace DesignPatterns.Creational.Prototype
{
    class Caller
    {
        public static void ICloneableIsBad()
        {
            var john = new Person(new[] { "John", "Smith" }, new DesignPatterns.Creational.Prototype.Bad.Address("London Road", 123));

            var jane = (Person)john.Clone();
            jane.Address.HouseNumber = 321; // oops, John is now at 321

            // this doesn't work
            //var jane = john;

            // but clone is typically shallow copy
            jane.Names[0] = "Jane";

            WriteLine(john);
            WriteLine(jane);
        }

        public static void CopyConstructors()
        {
            var john = new Employee("John", new Address("123 London Road", "London", "UK"));

            //var chris = john;
            var chris = new Employee(john);

            chris.Name = "Chris";
            WriteLine(john); // oops, john is called chris
            WriteLine(chris);
        }

        public static void CopyThroughSerialization()
        {
            Foo foo = new Foo { Stuff = 42, Whatever = "abc" };

            //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
            Foo foo2 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            WriteLine(foo);
            WriteLine(foo2);
        }


    }
}

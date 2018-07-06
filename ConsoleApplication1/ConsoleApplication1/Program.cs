using System;
using ConsoleApplication1.classes;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var OverviewTabInstance = new OverviewTab();
            var DomainsTabInstance = new DomainsTab();

            var value1 = OverviewTabInstance.OpenTab(DomainsTabInstance);

            Console.WriteLine($"********************* CHANGING TABS *********************");

            var value2 = DomainsTabInstance.OpenTab(OverviewTabInstance);

            Console.ReadLine();
        }
    }
}

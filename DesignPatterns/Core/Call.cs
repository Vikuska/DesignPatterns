using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Core
{
    public interface ICWrite
    {
        void WriteLine(object s);
    }

    public class CWrite
    {
        public static void WriteLine(object s)
        {
            Console.WriteLine(s);
        }
    }
}

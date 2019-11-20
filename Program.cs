using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        public static void NedelaNic()
        {
            Type t = typeof(Program);
            // vloží jen public metody!
            MemberInfo[] mi = t.GetMethods();
            foreach (var m in mi)
                Console.WriteLine(m.Name);
        }

        static void Main(string[] args)
        {
            NedelaNic();
        }
    }
}

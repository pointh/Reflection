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
            int i = 1;

            Type t = typeof(Program);
            // vloží jen public metody!
            MemberInfo[] mmbi = t.GetMethods();
            Console.WriteLine("Public methods of this class");
            foreach (var item in mmbi)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            MethodInfo mthi = t.GetMethod(MethodBase.GetCurrentMethod().Name);

            Console.WriteLine("\nThis method");
            Console.WriteLine("Method name: " + mthi.Name);
            Console.WriteLine("Local variables: " + mthi.GetMethodBody().LocalVariables[0]);
            Console.WriteLine("Return type: " + mthi.ReturnType);
        }

        static void Main(string[] args)
        {
            NedelaNic();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Multicast_Deligate
{
    class Program
    {
        //Multicast delegates must contain only methods that return void, else there is a run-time exception.
        delegate void Delegate_Multicast(int x, int y);

        static void Method1(int x, int y)
        {
            Console.WriteLine("You r in Method 1");
        }

        static void Method2(int x, int y)
        {
            Console.WriteLine("You r in Method 2");
        }

        static void Main(string[] args)
        {
            Delegate_Multicast func = new Delegate_Multicast(Method1);
            func += new Delegate_Multicast(Method2);
            func(1, 2);             // Method1 and Method2 are called
            func -= new Delegate_Multicast(Method1);
            func(2, 3);             // Only Method2 is called

        }
    }
}

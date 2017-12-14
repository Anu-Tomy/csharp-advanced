using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;      //  If the value of the first operand is null, then The Null Coalescing Operator(??) returns the value of the second operand, otherwise it returns the value of the first operand. 
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);            
        }
    }
}

/* Output
 * Value of num3: 5.34
   Value of num3: 3.14157
   */

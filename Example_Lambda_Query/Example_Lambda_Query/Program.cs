using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Lambda_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);
              
        }
    }
}

// Outputs: 4 scores are greater than 80  

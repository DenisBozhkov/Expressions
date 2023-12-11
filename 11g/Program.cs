using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Solve(new Binomial(a, b));
        }
        static void Solve(Binomial binomial)
        {
            List<double> result=binomial.Solve();
            if (result==null)
                Console.WriteLine("{0}=0 has infinitely many solutions!", binomial);
            else if (result.Count ==0)
                Console.WriteLine("{0}=0 has no solutions!", binomial);
            else Console.WriteLine("{0}=0 has 1 solution: {1}", binomial, result[0]);
        }
    }
}

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
        static void Solve(ISolvable solvable)
        {
            List<double> result = solvable.Solve();
            if (result == null)
                Console.WriteLine("{0}=0 has infinitely many solutions!", solvable);
            else if (result.Count == 0)
                Console.WriteLine("{0}=0 has no solutions!", solvable);
            else
            {
                Console.WriteLine("{0}=0 has {1} solutions: ", solvable, result.Count);
                for (int i = 0; i < result.Count; i++)
                    Console.Write(result[i] + " ");
                Console.WriteLine();
            }
        }
    }
}

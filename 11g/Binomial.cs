using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11g
{
    internal class Binomial : Polynomial
    {
        public Binomial(double a, double b)
            : base(new List<double> { a, b })
        { }
    }
}

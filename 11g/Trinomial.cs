using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11g
{
    internal class Trinomial : Binomial
    {
        public Trinomial(double a, double b, double c) : base(b, c)
        {
            coefficients.Add(a);
        }
        public double D
        {
            get { return coefficients[1] * coefficients[1] - 4 * coefficients[0] * coefficients[2]; }
        }
        public override List<double> Evaluate(double a)
        {
            if (coefficients[2] == 0)
                return base.Evaluate(a);
            double d = D + 4 * a * coefficients[2];
            if (d < 0)
                return new List<double>();
            else if (d == 0)
                return new List<double>() { -coefficients[1] / (2 * coefficients[2]) };
            else
                return new List<double>()
                {
                    (-coefficients[1] + Math.Sqrt(d)) / (2 * coefficients[2]),
                    (-coefficients[1] - Math.Sqrt(d)) / (2 * coefficients[2])
                };
        }
        public override string ToString()
        {
            return coefficients[2] + "x^2+" + base.ToString();
        }
    }
}

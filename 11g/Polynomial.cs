using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11g
{
    internal abstract class Polynomial : IExpression, ISolvable
    {
        protected List<double> coefficients;
        public Polynomial(List<double> coefficients)
        {
            this.coefficients = coefficients;
        }
        public int Power
        { get { return coefficients.Count - 1; } }
        public double Calculate(double x)
        {
            double res = coefficients[Power];
            for (int i = Power - 1; i >= 0; i--)
            {
                res = res * x + coefficients[i];
            }
            return res;
        }
        public virtual List<double> Solve()
        {
            return Evaluate(0);
        }
        public abstract List<double> Evaluate(double a);
    }
}

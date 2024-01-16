using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11g
{
    public interface ISolvable
    {
        List<double> Solve();
        List<double> Evaluate(double a);
    }
}

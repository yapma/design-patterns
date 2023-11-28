using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal interface IEmployee
    {
        double CalculateSallary();
        double CalculateTax();
    }
}

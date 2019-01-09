using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Calculation
    {
        public static void Calculate (decimal x, decimal y, Func<decimal, decimal, decimal> operationsHandler)
        {
            Calculator calculator = new Calculator();
            calculator.TurnOn();

            //decimal sum =           Operations.Sum(x, y);
            //decimal substruction =  Operations.Substruct(sum, x);
            //decimal mult =          Operations.Multiply(x, x);
            //decimal divide =        Operations.Divide(mult, substruction);

            operationsHandler(x, y);

            calculator.TurnOff();
        }
    }
}

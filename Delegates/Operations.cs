using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Operations
    {
        public static decimal Sum (decimal x, decimal y)
        {
            decimal result = x + y;
            Console.WriteLine("Sum operation has been performed. The result is: " + result);
            return result;
        }

        public static decimal Substruct (decimal x, decimal y)
        {
            decimal result = x - y;
            Console.WriteLine("Substruct operation has been performed. The result is: " + result);
            return result;
        }

        public static decimal Multiply (decimal x, decimal y)
        {
            decimal result = x * y;
            Console.WriteLine("Multiplication operation has been performed. The result is: " + result);
            return result;
        }

        public static decimal Divide (decimal x, decimal y)
        {
            decimal result;
            if (y != 0)
            {
                result = x / y;
                Console.WriteLine("Division operation has been performed. The result is: " + result);
                return result;
            }
            else
            {
                Console.WriteLine("Division operation failed");
                throw new DivideByZeroException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    /// <summary>
    /// Lambda expressions is:
    /// An anonymous method:
    /// - No access modifier (private/public)
    /// - No name 
    /// - No return statement
    /// We use them for convenience -> write less code
    /// </summary>
    public class LambdasTest
    {
        public static void TestLambda()
        {
            // args => expression
            // () => ...
            Func<int, int> func = (x => x * x);

            Console.WriteLine(func(5));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    public class DynamicType
    {
        public dynamic dynamicField;
        
        public void CheckType ()
        {
            dynamic dynamicVariable = 100;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = "Hello World!!";
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = true;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = DateTime.Now;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
        }

        public static void PrintValue(dynamic val)
        {
            Console.WriteLine(val);
        }
    }
}

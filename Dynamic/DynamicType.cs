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
            dynamicField = 3;
            Console.WriteLine(dynamicField);
            dynamicField = "hello";
            Console.WriteLine(dynamicField);
        }
    }
}

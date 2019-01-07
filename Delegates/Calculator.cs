using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /// <summary>
    /// Delegate is an object that knows how to call a method (or a group of methods)
    /// Delegate is a reference (or a pointer) to a function
    /// Used for designing extensible and flexible applications
    /// 
    /// Use a delegate when:
    /// - An eventing design pattern is used
    /// - The caller doesn't need to access other properties or methods on the object implementing the method
    /// </summary>
    public class Calculator
    {
        public string Manufacturer { get; set; }
        public string DisplayType { get; set; }
        public string Status { get; set; }

        public void TurnOn ()
        {
            Status = "ON";
        }

        public void TurnOff()
        {
            Status = "OFF";
        }

    }
}

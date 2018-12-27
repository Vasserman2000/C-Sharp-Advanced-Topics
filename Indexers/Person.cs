using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Person
    {
        public string job;
        public string name;
        public decimal experience;
        public string[] titles = new string[4] { "Mr.", "Mrs.", "Ms.", "Sir"};

        public Person(string jobDescription, string personName, decimal experienceInMonthes, string company)
        {
            job = jobDescription;
            name = personName;
            experience = experienceInMonthes;
        }

        public string this [int index]
        {
            get { return titles[index]; }
            set { titles[index] = value; }
        }
    }
}

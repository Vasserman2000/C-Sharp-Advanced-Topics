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
    /// We use them for convenience --> write less code
    /// We use lambda operator (=>)
    /// </summary>
    public class LambdasTest
    {
        public static void TestLambda()
        {
            const int factor = 10;
            // args => expression
            // () => ...
            Func<int, int> func = x => x * x;
            Func<int, bool> isEvenNumer = x => x % 2 == 0;
            Func<int, int> multiply = x => x * factor;

            Console.WriteLine(func(5));
            Console.WriteLine(isEvenNumer(8));
            Console.WriteLine(multiply(8));

            var jobs = AllJobs.GetJobs();

            var lessThan5Years = jobs.FindAll(job => job.ExperienceNeeded < 5); //less code
            var moreOrEqualTo5years = jobs.FindAll(AllJobs.Is5YearsRequired);

            foreach (var job in lessThan5Years)
            {
                Console.WriteLine(job.CompanyName);
            }

            foreach (var job in moreOrEqualTo5years)
            {
                Console.WriteLine(job.CompanyName);
            }
        }

    }

    public class AllJobs
    {
        public static List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job { ExperienceNeeded = 3, ProgrammingLanguage = "C#", CompanyName = "Microsoft" },
                new Job { ExperienceNeeded = 5, ProgrammingLanguage = "Java", CompanyName = "Checkpoint" },
                new Job { ExperienceNeeded = 2, ProgrammingLanguage = "Ruby", CompanyName = "Seeking Alpha" }
            };
        }

        public static bool Is5YearsRequired (Job job)
        {
            return job.ExperienceNeeded >= 5;
        }
    }

    public class Job
    {
        public int ExperienceNeeded { get; set; }
        public string ProgrammingLanguage { get; set; }
        public string CompanyName { get; set; }

        //public Job(int experience, string language, string companyName)
        //{
        //    ExperienceNeeded = experience;
        //    ProgrammingLanguage = language;
        //    CompanyName = companyName;
        //}
    }
}

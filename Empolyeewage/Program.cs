using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    internal class Program
    {
         public const int EMP_RATE_PER_HOUR = 20;
         public const int NUM_OF_WORKING_DAYS = 20;
         public int MAX_WORKING_HOUR = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compute UC8");
            CheckEmployeeWage("SMT", 24, 140, 40);
            CheckEmployeeWage("SS steels", 26, 110, 35);
            CheckEmployeeWage(" TMT", 23, 130, 65);
            Console.ReadLine();


        }


        public static void CheckEmployeeWage( string company, int maxWorkingDays, int maxWorkingHrs, int empRatePerHrs)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int emphrs = 0;
            int empwage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
          
            Random random = new Random();

            while (day <= maxWorkingDays && totalHrs < maxWorkingHrs)
            {
                
                
                int randomInput = random.Next(1, 3);
                switch (randomInput)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;

                }
                empwage=empRatePerHrs* emphrs;
                totalWage += empwage;
                totalHrs += emphrs;
                day++;
                //Console.WriteLine("Employee Wage per day{0}:{1}", day, empwage);
            }
            Console.WriteLine("Total Wage:{0} for {1} of {2}days and TotalHrs :{3}  ", totalWage, company, (day - 1), totalHrs);



        }
        
    }
}

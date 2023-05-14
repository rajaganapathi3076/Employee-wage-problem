using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HOUR_IN_MONTH = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmpolyeeWagecalculUC6");
            int emphrs = 0, totalemphrs = 0, totaWorkindays = 0;
            while (totalemphrs <= MAX_HOUR_IN_MONTH && totaWorkindays < NUM_OF_WORKING_DAYS)
            {
                totaWorkindays++;
                Random random1 = new Random();
                int empCheck = random1.Next(0, 3);
                switch (empCheck)
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
                totalemphrs = +emphrs;
                Console.WriteLine("Day :" + totaWorkindays + "emphrs :" + emphrs);

            }
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Totalempwage :" + totalempwage);
            Console.WriteLine("The total Empolyee wage no of days :" +totalempwage * NUM_OF_WORKING_DAYS);
            Console.ReadLine();
        }
    }
}

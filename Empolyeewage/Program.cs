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

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWagecalUC4");

            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
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
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Empwage :" + empwage);
            Console.ReadLine();
        }
    }
}

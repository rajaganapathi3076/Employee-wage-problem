using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    internal class EmpWageBuilder
    {
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            totalEmpWage = 0;
        }

        public void ComputeEmpWage()
        {
            // Compute the total wage for the company
            // using the instance variables

            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHours = 0;

            while (totalEmpHours < maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHours += empHrs;
            }

            totalEmpWage = totalEmpHours * empRatePerHour;
        }

        public void DisplayEmpWage()
        {
            Console.WriteLine("Total wage for company " + company +  " is "  + totalEmpWage);
        }
    }
}


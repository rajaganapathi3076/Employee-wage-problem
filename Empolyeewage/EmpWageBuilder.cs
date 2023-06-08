using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    internal class EmpWageBuilder : IEmpWageCalculator

    {
        private List<CompanyEmpWage> companyEmpWages;

        public EmpWageBuilder()
        {
            companyEmpWages = new List<CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWages.Add(companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWages)
            {
                int empHrs = 0;
                int totalWorkingDays = 0;
                int totalEmpHours = 0;

                while (totalEmpHours < companyEmpWage.MaxHoursPerMonth && totalWorkingDays < companyEmpWage.NumOfWorkingDays)
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
                    int dailyWage = empHrs * companyEmpWage.EmpRatePerHour;
                    companyEmpWage.DailyWages.Add(dailyWage);
                }

                companyEmpWage.TotalEmpWage = totalEmpHours * companyEmpWage.EmpRatePerHour;
            }
        }

        public void DisplayEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWages)
            {
                Console.WriteLine("Total wage for company " + companyEmpWage.Company + " is " + companyEmpWage.TotalEmpWage);
                Console.WriteLine("Daily wages for company " + companyEmpWage.Company + ":");
                foreach (int dailyWage in companyEmpWage.DailyWages)
                {
                    Console.WriteLine(dailyWage);
                }
            }
        }

        public int GetTotalWageByCompany(string company)
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWages)
            {
                if (companyEmpWage.Company == company)
                {
                    return companyEmpWage.TotalEmpWage;
                }
            }
            return 0; // Return 0 if company not found
        }
    }
        
    
}


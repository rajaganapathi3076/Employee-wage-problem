using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    internal class EmpWageBuilder
    {
        private CompanyEmpWage[] companyEmpWages;
        private int numCompanies;

        public EmpWageBuilder()
        {
            companyEmpWages = new CompanyEmpWage[5];
            numCompanies = 0;
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWages[numCompanies] = companyEmpWage;
            numCompanies++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numCompanies; i++)
            {
                CompanyEmpWage companyEmpWage = companyEmpWages[i];
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
                }

                companyEmpWage.TotalEmpWage = totalEmpHours * companyEmpWage.EmpRatePerHour;
            }
        }

        public void DisplayEmpWage()
        {
            for (int i = 0; i < numCompanies; i++)
            {
                Console.WriteLine("Total wage for company " + companyEmpWages[i].Company + " is " + companyEmpWages[i].TotalEmpWage);
            }
        }
    }
}


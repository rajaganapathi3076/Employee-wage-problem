using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyeewage
{
    interface IEmpWageCalculator
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeEmpWage();
        void DisplayEmpWage();
    }
    internal class CompanyEmpWage
    {
        public string Company { get; }
        public int EmpRatePerHour { get; }
        public int NumOfWorkingDays { get; }
        public int MaxHoursPerMonth { get; }
        public int TotalEmpWage { get; set; }
        public List<int> DailyWages { get; }

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            Company = company;
            EmpRatePerHour = empRatePerHour;
            NumOfWorkingDays = numOfWorkingDays;
            MaxHoursPerMonth = maxHoursPerMonth;
            TotalEmpWage = 0;
            DailyWages = new List<int>();
        }
    }
}

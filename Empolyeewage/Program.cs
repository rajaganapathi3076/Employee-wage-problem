using Empolyeewage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmpWage calculation UC 14");
            IEmpWageCalculator empWageBuilder = new EmpWageBuilder();

            empWageBuilder.AddCompanyEmpWage("SS PRIVATE LIMITED", 20, 20, 106);
            empWageBuilder.AddCompanyEmpWage("SMT STEEL PVT", 15, 25, 110);
            empWageBuilder.AddCompanyEmpWage("SMT STEEL PVT", 15, 25, 110);
            empWageBuilder.AddCompanyEmpWage("TATA STEEL PVT", 30, 25, 90);

            empWageBuilder.ComputeEmpWage();
            empWageBuilder.DisplayEmpWage();


            string queriedCompany = "SMT STEEL PVT";
            int totalWage = empWageBuilder.GetTotalWageByCompany(queriedCompany);
            Console.WriteLine("Total wage for company " + queriedCompany + " is " + totalWage);
        }



    }
}

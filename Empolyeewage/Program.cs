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
            EmpWageBuilder company1 = new EmpWageBuilder("SS PRIVATE LIMITED", 20, 20, 100);
            company1.ComputeEmpWage();
            company1.DisplayEmpWage();

            EmpWageBuilder company2 = new EmpWageBuilder("SMT STEELS", 56, 35, 120);
            company2.ComputeEmpWage();
            company2.DisplayEmpWage();

            EmpWageBuilder company3 = new EmpWageBuilder("TATA STEELS", 23, 60, 120);
            company2.ComputeEmpWage();
            company2.DisplayEmpWage();

        }

    }
        
    
}

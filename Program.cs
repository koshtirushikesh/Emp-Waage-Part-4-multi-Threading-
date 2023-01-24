
using System.Net;

namespace EmployeePayRollServices
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<EmployeeDetails> Employeelist = new List<EmployeeDetails>();

            Employeelist.Add(new EmployeeDetails(1, "Rushi","hr", 8898338339 ));
            Employeelist.Add(new EmployeeDetails(2, "Rutik","head", 890567435 ));
            Employeelist.Add(new EmployeeDetails(3, "Ram","md", 89045635 ));
            Employeelist.Add(new EmployeeDetails(4, "Raju","leader", 80345325 ));

            EmpPayrollOperation operation = new EmpPayrollOperation();
            operation.AddEmpToPAyRollList(Employeelist);
        }
        
    }
}
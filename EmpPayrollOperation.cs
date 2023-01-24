using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollServices
{
    public class EmpPayrollOperation
    {
        public List<EmployeeDetails> EmpDetailsList=new List<EmployeeDetails>();

        public void AddEmpToPAyRollList(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.AddEmpToPAyRollList(employeeData);
                Console.WriteLine("Employee Added: "+ employeeData.EmployeeName);

            });
        }

        private void AddEmpToPAyRollList(EmployeeDetails employeeData)
        {
            EmpDetailsList.Add(employeeData);
        }

        public void AddEmpToPAyRollListWithThread(List<EmployeeDetails> employeeDetails)
        {
            
            employeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {

                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    this.AddEmpToPAyRollList(employeeData);
                    Console.WriteLine("Employee Added: " + employeeData.EmployeeName);

                });
                thread.Start();
      
            });
        }
    }
}

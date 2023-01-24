using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollServices
{
    public class EmployeeDetails
    {
        public EmployeeDetails(int Id,string name,string Description,long phonenumber)
        {
            this.EmployeeId = Id;
            this.EmployeeName = name;
            this.EmployeeDescription = Description;
            this.EmployeePhone = phonenumber;

        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDescription { get; set; }
        public long EmployeePhone { get; set; }
    }
}

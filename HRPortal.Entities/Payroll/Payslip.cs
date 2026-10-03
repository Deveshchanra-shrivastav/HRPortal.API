using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public class Payslip : AuditEntity
    {
        public int PayslipId { get; set; }

        public int OrganizationMasterId { get; set; }

        public int EmployeeMasterId { get; set; }

        public int SalaryId { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public decimal TotalEarnings { get; set; }

        public decimal TotalDeductions { get; set; }

        public decimal NetSalary { get; set; }

        public DateTime GeneratedDate { get; set; }
    }
}

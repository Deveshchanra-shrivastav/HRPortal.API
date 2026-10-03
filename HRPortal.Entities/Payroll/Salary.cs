using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public class Salary : AuditEntity
    {
        public int SalaryId { get; set; }

        public int OrganizationMasterId { get; set; }

        public int EmployeeMasterId { get; set; }

        public DateTime EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        public decimal GrossSalary { get; set; }

        public decimal TotalEarnings { get; set; }

        public decimal TotalDeductions { get; set; }

        public decimal NetSalary { get; set; }
    }
}

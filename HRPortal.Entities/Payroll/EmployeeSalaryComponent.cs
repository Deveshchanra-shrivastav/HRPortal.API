using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public class EmployeeSalaryComponent : AuditEntity
    {
        public int EmployeeSalaryComponentId { get; set; }

        public int EmployeeMasterId { get; set; }

        public int OrganizationMasterId { get; set; }

        public int SalaryComponentMasterId { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Percentage { get; set; }

        public DateTime EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }
    }
}

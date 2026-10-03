using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public class SalaryComponent : AuditEntity
    {
        public int SalaryComponentMasterId { get; set; }

        public int OrganizationMasterId { get; set; }

        public string ComponentCode { get; set; } = string.Empty;

        public string ComponentName { get; set; } = string.Empty;

        public PayrollComponentType ComponentType { get; set; }

        public PayrollCalculationType CalculationType { get; set; }

        public string? Description { get; set; }
    }
}

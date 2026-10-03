using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public class PayslipComponent : AuditEntity
    {
        public int PayslipComponentId { get; set; }

        public int PayslipId { get; set; }

        public int OrganizationMasterId { get; set; }

        public int SalaryComponentMasterId { get; set; }

        public string ComponentCode { get; set; } = string.Empty;

        public string ComponentName { get; set; } = string.Empty;

        public PayrollComponentType ComponentType { get; set; }

        public decimal Amount { get; set; }

        public decimal? Percentage { get; set; }
    }

}

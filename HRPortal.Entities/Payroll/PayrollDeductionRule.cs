using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public class PayrollDeductionRule : AuditEntity
    {
        public int PayrollDeductionRuleId { get; set; }
        
        public int OrganizationMasterId { get; set; }

        public int SalaryComponentMasterId { get; set; }

        public int CountryId { get; set; }

        public int? StateId { get; set; }

        public string RuleName { get; set; } = string.Empty;

        public PayrollCalculationType CalculationType { get; set; }

        public decimal? Percentage { get; set; }

        public decimal? FixedAmount { get; set; }

        public decimal? MinimumLimit { get; set; }

        public decimal? MaximumLimit { get; set; }

        public DateTime EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        public string? Formula { get; set; }

        public string? Description { get; set; }
    }
}

using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class EmployeeDepartment : AuditEntity
    {
        public int EmployeeDepartmentId { get; set; }

        public int EmployeeMasterId { get; set; }

        public int OrganizationMasterId { get; set; }

        public int DepartmentMasterId { get; set; }

        public bool IsPrimaryDepartment { get; set; }

        public DateTime EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }
    }
}

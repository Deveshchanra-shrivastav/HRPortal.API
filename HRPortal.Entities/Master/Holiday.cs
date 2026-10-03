using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class Holiday : AuditEntity
    {
        public int HolidayMasterId { get; set; }

        public string HolidayName { get; set; } = string.Empty;

        public int OrganizationMasterId { get; set; }

        public DateTime HolidayDate { get; set; }

        public string? Description { get; set; }
    }
}

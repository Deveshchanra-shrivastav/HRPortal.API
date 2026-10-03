using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Payroll
{
    public enum PayrollCalculationType
    {
        FixedAmount = 1,
        Percentage = 2,
        Slab = 3,
        Formula = 4
    }
}

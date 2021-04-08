using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class DiagnosePrescription
    {
        public int PrescriptionId { get; set; }
        public int DiagnoseId { get; set; }

        public virtual Diagnose Diagnose { get; set; }
    }
}

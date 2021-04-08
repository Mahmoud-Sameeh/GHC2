using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class PrescriptionMedicine
    {
        public int PrescriptionId { get; set; }
        public int MedicineId { get; set; }
        public string Dose { get; set; }
        public string Note { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual DiagnosePrescription Prescription { get; set; }
    }
}

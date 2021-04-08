using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DocId { get; set; }
        public DateTime AppointmetDateTime { get; set; }
        public string Note { get; set; }
        public string Accepted { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

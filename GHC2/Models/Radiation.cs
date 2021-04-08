using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Radiation
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int PatientId { get; set; }
        public int DocId { get; set; }
        public string Report { get; set; }
        public string Note { get; set; }
        public string AttachUrl { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

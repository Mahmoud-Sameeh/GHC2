using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Chat
    {
        public Int64 Id { get; set; }
        public Int64 PatientId { get; set; }
        public Int64 DocId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Message { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

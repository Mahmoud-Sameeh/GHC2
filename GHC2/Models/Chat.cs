using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DocId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Message { get; set; }

        public virtual Doctor Doc { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Patient
    {
        public int Nid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? BitrhDate { get; set; }
        public string Address { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<Analysis> Analyses { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Diagnose> Diagnoses { get; set; }
        public virtual ICollection<Radiation> Radiations { get; set; }
    }
}

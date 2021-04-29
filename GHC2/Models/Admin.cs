using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    public class Admin
    {
        [Key]
        public Int64 Nid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BitrhDate { get; set; }
        public string Address { get; set; }
        public Int64? Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Position { get; set; }
        public string IdentityId { get; set; }
    }
}

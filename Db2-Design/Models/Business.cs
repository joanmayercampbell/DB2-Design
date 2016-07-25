using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Db2_Design.Models
{
    public class Business
    {
        public int BusinessID { get; set; }
        public int BusinessTypeID { get; set; }
        public int UserID { get; set; }
        [MaxLength(100)]
        public string BusinessName { get; set; }
        [MaxLength(100)]
        public string Hours { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        public string Menu { get; set; }

        public virtual BusinessType BusinessType { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
            
    }
}
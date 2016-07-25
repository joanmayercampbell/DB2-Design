using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Db2_Design.Models
{
    public class User
    {
        public int UserID { get; set; }
        [MaxLength(100)]
        public string UserName { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string EmailAddress { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
    }
}
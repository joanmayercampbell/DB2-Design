using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Db2_Design.Models
{
    public class BusinessType
    {
        public int BusinessTypeID { get; set; }
        [MaxLength(100)]
        public string BusinessTypeName { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }
    }
}
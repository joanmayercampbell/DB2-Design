using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Db2_Design.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public int Stars { get; set; }
        public string Text { get; set; }

        public virtual User User { get; set; }
        public virtual Business Business { get; set; }
    }
}
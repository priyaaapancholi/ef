using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolAppEF.Models
{
    public class student
    {
       // [Required]
        [Key]
        public int sID { set; get; }
      
       // public int cId { set; get; }
        public string sn { set; get; }
        public course crs { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolAppEF.Models
{
    public class course
    {
        [Key]
        //[Required]
        public int cId { set; get; }
        
       
        public string cn { set; get;}
        // [ForeignKey("sID")]
        public int sID { set; get; }
        public List<student> std { set; get; }
    }
}
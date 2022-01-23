using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class Permission
    {
        [Key]
        public int ID { set; get; }
        public bool Add { set; get; }

        public bool Edit { set; get; }
        public bool Delete { set; get; }

        public bool View { set; get; }
        public string Module { set; get; }
        public string Role { set; get; }
    }
}
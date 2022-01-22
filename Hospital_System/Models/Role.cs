using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class Role
    {
        public int roleID { set; get; }

        [Display(Name = "Role Name")]
        public string roleName { set; get; }

        [Display(Name = "Description")]
        public string description { set; get; }
    }
}
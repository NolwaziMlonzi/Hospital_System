using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userID { set; get; }

        [Display(Name = "User Name")]
        public string userName { set; get; }

        [Display(Name = "First Name")]
        public string FirstName { set; get; }

        [Display(Name = "Last Name")]
        public string LastName { set; get; }

        [Display(Name = "Role")]
        public string role { set; get; }

        [Display(Name = "Password")]
        public string password { set; get; }
    }
}
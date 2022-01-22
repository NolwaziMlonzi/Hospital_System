using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int doctorID { set; get; }

        [Display(Name = "Doctor Full Name")]
        public string doctorFullName { set; get; }

        [Display(Name = "Doctor's Physical Address")]
        public string doctorPhysicalAddress { set; get; }

        [Display(Name = "Doctor Phone Number")]
        public string doctorPhoneNumber { set; get; }

        [Display(Name = "Qualification")]
        public string qualification { set; get; }

        [Display(Name = "Gender")]
        public string gender { set; get; }

        [Display(Name = "Appointment")]
        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}
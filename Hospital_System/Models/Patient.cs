using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int patientID { set; get; }

        [Display(Name = "Patient Full Name")]
        public string patientFullName { set; get; }

        [Display(Name = "Patient Age")]
        public int patientAge { set; get; }

        [Display(Name = "Patient Gender")]
        public string patientGender { set; get; }

        [Display(Name = "Patient's Physical Address")]
        public string patientPhysicalAddress { set; get; }

        [Display(Name = "Date")]
        public string date { set; get; }

        [Display(Name = "Patient's Contact Number")]
        public string patientContactNumber { set; get; }

        [Display(Name = "Patient's Room Number")]
        public string patientRoomNumber { set; get; }
    }
}
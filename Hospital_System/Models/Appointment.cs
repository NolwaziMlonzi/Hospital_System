using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int appointmentID { set; get; }

        [Display(Name = "Patient ID No.")]
        public int patientID { set; get; }

        [Display(Name = "Date and Time")]
        public string date { set; get; }

        [Display(Name = "Doctor's ID No.")]
        [ForeignKey("Doctor")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int doctorID
        {
            get;
            set;
        }

        [Display(Name = "Doctor's Name")]
        public virtual ICollection<Doctor> Doctor { get; set; }

    }
}

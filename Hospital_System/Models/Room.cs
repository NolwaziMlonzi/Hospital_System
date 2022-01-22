using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital_System.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roomID { set; get; }

        [Display(Name = "Room Number")]
        public string RoomNumber { set; get; }

        [Display(Name = "Room Type")]
        public string roomType { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20,MinimumLength =4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Currency)]
        [DisplayName("Patient's Net Worth")]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Name of the Doctor treating you")]
        public string DoctorName { get; set; }
        [Range(1,10)]
        [DisplayName("Your pain level")]
        public int PainLevel { get; set; }
    }
}

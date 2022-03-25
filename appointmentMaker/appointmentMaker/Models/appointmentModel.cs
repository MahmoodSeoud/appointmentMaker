using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace appointmentMaker.Models
{
    public class appointmentModel
    {   [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's Full Name")]
        public string PatientName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }


        [Required]
        [DisplayName("Doctors's Full Name")]
        public string DocterName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's Percieved Level of Pain (1 low to 10 high)")]
        public int PainLvl { get; set; }

    }
}

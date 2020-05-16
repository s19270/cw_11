using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw_11.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        [ForeignKey("Doctor")]
        public int? IdDoctor { get; set; }
        public virtual Doctor Doctor { get; set; }
        [Required]
        [ForeignKey("Patient")]
        public int? IdPatient { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

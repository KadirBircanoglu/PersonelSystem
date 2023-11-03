using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem_EL.Entities
{
    public class Personel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [MinLength(2)]
        [Required]

        public string Name { get; set; }

        [StringLength(50)]
        [MinLength(2)]
        [Required]

        public string Surname { get; set; }

        [StringLength(50)]
        [EmailAddress]
        [Required]

        public string Email { get; set; }

        [StringLength(20)]
        [Required]

        public string Phone { get; set; }

        [StringLength(11)]
        [MinLength(11)]
        public string TCNumber { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }    
        public string EducationStatus { get; set;}
        [DefaultValue(true)]
        public bool IsActive { get; set;}

    }
}

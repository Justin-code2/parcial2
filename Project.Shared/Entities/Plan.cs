using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project.Shared.Entities
{
    public class Plan
    {
        public int Id { get; set; }

        [Display(Name = "Name Project")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NamePro { get; set; }

        [Display(Name = "Description project")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DescripPro { get; set; }

        [Display(Name = "State")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string StatePro { get; set; }

        [Display(Name = "End Date")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateEnd { get; set; }



        //[JsonIgnore]
        //// Clave foránea para Mentor
        //public int MentorId { get; set; }  // Clave foránea
        //public Mentor Mentor { get; set; }  // Propiedad de navegación


        //[JsonIgnore]
        //// Clave foránea para Team (uno-a-uno)
        //public int TeamId { get; set; }  // Clave foránea
        //public Team Team { get; set; }  // Propiedad de navegación


        //[JsonIgnore]
        //// Relación uno-a-muchos: un Proyecto tiene varias Evaluaciones
        //public ICollection<Evaluation> Evaluations { get; set; }

    }
}
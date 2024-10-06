using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project.Shared.Entities
{
    public class Participant
    {
        public int Id { get; set; }

        [Display(Name = "Name Participant")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameParti { get; set; }

        [Display(Name = "Role")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string RoleParti { get; set; }

        [Display(Name = "Experience")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ExperienceParti { get; set; }


        //[JsonIgnore]
        //public int TeamId { get; set; }  // Clave foránea
        //public Team Team { get; set; }  // Propiedad de navegación


    }
}
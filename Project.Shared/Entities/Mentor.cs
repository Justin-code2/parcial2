using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project.Shared.Entities
{
    public class Mentor
    {
        public int Id { get; set; }

        [Display(Name = "Name Mentor")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameMentor { get; set; }

        [Display(Name = "Area experience")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string AreaExp { get; set; }


        //[JsonIgnore]
        //// Relación uno-a-muchos: un Mentor puede supervisar varios Equipos
        //public ICollection<Team> Teams { get; set; }  // Propiedad de navegación


        //[JsonIgnore]
        //// Relación uno-a-muchos: un Mentor puede supervisar varios Proyectos
        //public ICollection<Plan> Plans { get; set; }  // Propiedad de navegación

    }
}
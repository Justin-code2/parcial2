using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Prize
    {
        public int Id { get; set; }

        [Display(Name = "Description prize")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DescripPriz { get; set; }



        //// Clave foránea para Hackathon
        //public int HackId { get; set; }  // Clave foránea
        //public Hack Hack { get; set; }  // Propiedad de navegación

        //// Clave foránea para Team (equipo ganador)
        //public int TeamId { get; set; }  // Clave foránea
        //public Team Team { get; set; }  // Propiedad de navegación

    }
}
using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Team
    {

        public int Id { get; set; }

        [Display(Name = "Name Team")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameTe { get; set; }

        [Display(Name = "Number of members")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NumberMem { get; set; }

        [Display(Name = "Experience")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ExperienceTeam { get; set; }


        //[JsonIgnore]
        //public int HackId { get; set; }  // Clave foránea
        //public Hack Hack { get; set; }  // Propiedad de navegación


        //[JsonIgnore]
        //// Relación uno-a-muchos: un Equipo tiene varios Participantes
        //public ICollection<Participant> Participants { get; set; }


        //[JsonIgnore]
        //// Clave foránea para Mentor
        //public int MentorId { get; set; }  // Clave foránea
        //public Mentor Mentor { get; set; }  // Propiedad de navegación


        //// Clave foránea para Proyecto (uno-a-uno)
        //public int PlanId { get; set; }  // Clave foránea
        //public Plan Plan { get; set; }  // Propiedad de navegación

    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project.Shared.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }

        [Display(Name = "Score")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Score { get; set; }

        [Display(Name = "Mentor comment")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string CommentMent { get; set; }



        //// Clave foránea para Proyecto
        //public int PlanId { get; set; }  // Clave foránea
        //public Plan Plan { get; set; }  // Propiedad de navegación

        //// Clave foránea para Mentor
        //public int MentorId { get; set; }  // Clave foránea
        //public Mentor Mentor { get; set; }  // Propiedad de navegación



    }
}
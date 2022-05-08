using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        //features of Actor class
        [Key]
        public int ActorID { get; set; }

        [Display(Name = "Profile Picture")]
       // [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
       // [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }


        [Display(Name = "Biography")]
       // [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationship

        public List<Actore_Movie> actore_Movies{ get; set; }
    }
}

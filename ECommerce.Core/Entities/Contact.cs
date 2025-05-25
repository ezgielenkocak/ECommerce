using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    //To record requests received via the contact form
    public class Contact:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0}  is required")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string?  Phone { get; set; }
        [Display(Name="Your Message"), Required(ErrorMessage = "{0}  is required")]

        public string Message { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }//= DateTime.Now;    

    }
}

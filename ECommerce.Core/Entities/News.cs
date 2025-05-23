using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class News :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }=string.Empty; 
        public string? Image { get; set; } //make it nullable especially for image files as it can cause problems

        [Display(Name="Active")]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

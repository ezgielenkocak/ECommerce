using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; } //make it nullable especially for image files, as it can cause problems
        [Display(Name="Active")]
        public bool IsActive { get; set; }

        [Display(Name="See In Top Menu")]
        public bool IsTopMenu { get; set; }

        [Display(Name="Parent Category")]
        public int ParentId { get; set; }
        public int OrderNo { get; set; } //you may want to sort

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } =DateTime.Now;  

        public IList<Product>? Products { get; set; }

    }
}

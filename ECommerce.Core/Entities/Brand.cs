using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; } = string.Empty; //make it nullable especially for image files, as it can cause problems
        [Display(Name="Active")]
        public bool IsActive { get; set; }
        public int OrderNo { get; set; } //you may want to sort

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public IList<Product>? Products { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; } //make it nullable especially for image files, as it can cause problems
        public decimal Price { get; set; }
        public string? ProductCode { get; set; }
        public int Stock { get; set; }
        [Display(Name="Active")]
        public bool IsActive { get; set; }
        [Display(Name = "See In Homepage")]
        public bool IsHome { get; set; }

        [Display(Name="Category")]
        public int? CategoryId { get; set; }

        [Display(Name = "Category")]
        public Category? Category { get; set; }

        [Display(Name = "Brand")]
        public int? BrandId { get; set; }

        [Display(Name = "Brand")]
        public Brand? Brand { get; set; }

        public int OrderNo { get; set; } //you may want to sort in products
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

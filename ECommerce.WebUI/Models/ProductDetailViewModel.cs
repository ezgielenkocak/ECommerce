using ECommerce.Core.Entities;

namespace ECommerce.WebUI.Models
{
    public class ProductDetailViewModel
    {
        public Product?  Product { get; set; }
        public IEnumerable<Product>? RelatedProducts { get; set; }
    }
}

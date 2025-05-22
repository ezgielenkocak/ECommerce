using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string? Phone { get; set; }
        public string Password { get; set; }
        public string? UserName { get; set; }
        [Display(Name="Active")]
        public bool IsActive { get; set; }
        [Display(Name="Admin")]
        public bool IsAdmin { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [ScaffoldColumn(false)]
        public Guid? UserGuid {  get; set; } = Guid.NewGuid();    

    }
}

using System.ComponentModel.DataAnnotations;

namespace PharmaStockManager.Models
{
    public class Category
    {
        public int Id { get; set; }


        public string UserId { get; set; } // Kategori sahibi kullanıcı

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}

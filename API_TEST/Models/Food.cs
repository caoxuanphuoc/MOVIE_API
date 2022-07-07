using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API_TEST.Models
{
    public class Food
    {
        [Key]
        public int ID { get; set; }
        public string FoodName { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
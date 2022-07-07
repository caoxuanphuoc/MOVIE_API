using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API_TEST.Models
{
    public class Bill
    {
        [Key]
        public int ID { get; set; }
        public string CustomerId { get; set; } = string.Empty;

        public string MovieId{ get; set; } = string.Empty;
        public string FoodId{ get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
    }
}
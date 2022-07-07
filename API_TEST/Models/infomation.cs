using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API_TEST.Models
{
    public class infomation 
    {
        
        public string FirstName { get; set; } = string.Empty;
        public string LastName{ get; set; } = string.Empty;
         [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { get; set; }
       
    }
}
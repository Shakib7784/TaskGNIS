using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskGNIS.Models
{
    public class Products_Service_Tbl
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public int quantity { get; set; }
    }
}

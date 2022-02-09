
using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string InventoryName { get; set; }
        [Range(0,int.MaxValue, ErrorMessage = "{0} must be greater than equal to 0")]
        public int Quantity { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "{0} must be greater than equal to 0")]
        public double Price { get; set; }
    }
}
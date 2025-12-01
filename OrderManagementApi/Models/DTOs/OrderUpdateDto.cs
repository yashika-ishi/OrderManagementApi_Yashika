using System.ComponentModel.DataAnnotations;

namespace OrderManagementApi.Models.DTOs
{
    public class OrderUpdateDto
    {
        [Required]
        public string ProductName { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0.0, double.MaxValue)]
        public decimal UnitPrice { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int  Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        [Precision(18, 2)]

        public decimal Price { get; set; }
        public Book Book { get; set; }
    }
}

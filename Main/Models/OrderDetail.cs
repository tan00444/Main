using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int order_id { get; set; }
        [Key]
        [Column(Order = 2)]
        public int book_id { get; set; }
        [ForeignKey("order_id")]
        public virtual Order order { get; set; }
        [ForeignKey("pro_id")]
        public virtual Book book { get; set; }
        public int orderdetail_id { get; set; }
        public double orderdetail_total { get;set; }
        public double orderdetail_quantity { get; set; }
    }
}

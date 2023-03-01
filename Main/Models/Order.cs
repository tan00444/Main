using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public string order_date { get; set;}
        public string order_total { get; set;}
    }
}

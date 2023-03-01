using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string book_des { get; set;}
        public string book_img { get; set;}
        public string book_author { get; set;}
        public string book_quantity { get; set;}
        public string book_price { get; set;}
        [ForeignKey("cate_id")]
        public virtual Category? category { get; set; }

    }
}

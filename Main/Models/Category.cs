using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Main.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cate_id;
        [Required]
        public string cate_name;
        [Required]
        public virtual ICollection<Book>? book { get; set; }
    }
}

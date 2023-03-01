using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class Pulisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pu_id;
       
        public string pu_name;

        public string pu_des;

        public string pu_phone;

        public string pu_address;

        [Required]
        public virtual ICollection<Book>? book { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Main.Models
{
    public class Feedback
    {
        [Key]
        public int feed_id { get; set; }
        public int feed_content { get; set;}
        public int feed_date { get; set;}
    }
}

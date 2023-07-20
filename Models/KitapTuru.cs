using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
    public class KitapTuru
    {
        [Key]    //primary key
        public int Id{ get; set; }
        [Required]      //null olamaz
        public string Ad{ get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int AdminId { get; set; }
        public  string Email { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
    }
}

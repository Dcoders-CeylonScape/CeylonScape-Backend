using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class Children
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public string Gender { get; set; }

    public string PlaceOfBirth { get; set; }

    public int UserInfoId { get; set; }
    public UserInfo UserInfo { get; set; }
}
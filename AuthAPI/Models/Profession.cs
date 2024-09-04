using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;

public class Profession
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)]
    public string NameOfWorkplace { get; set; }

    [MaxLength(255)]
    public string AddressOfWorkplace { get; set; }

    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(20)]
    public string Fax { get; set; }

    public int UserInfoId { get; set; }
    public UserInfo UserInfo { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class EmergencyContact
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(255)]
    public string Address { get; set; }

    [Required]
    [MaxLength(20)]
    public string Contact { get; set; }

    [MaxLength(50)]
    public string? Relationship { get; set; }

    public string? Support { get; set; }

    public double UsdAmount { get; set; }
    
    public double SpendableAmount { get; set; }
    
    public string nameOfCreditCard { get; set; }
    
    public int UserInfoId { get; set; }
    public UserInfo? UserInfo { get; set; }
}
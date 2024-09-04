using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class Business
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)]
    public string NameOfBusiness { get; set; }

    [MaxLength(255)]
    public string AddressOfBusiness { get; set; }

    [MaxLength(100)]
    public string RegistrationNumber { get; set; }

    [MaxLength(50)]
    public string SharesOwned { get; set; }

    public int ResidenceVisaInfoId { get; set; }
    public ResidenceVisaInfo ResidenceVisaInfo { get; set; }
}
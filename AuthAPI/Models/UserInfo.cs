using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;

public class UserInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? FullName { get; set; }

    [MaxLength(50)]
    public string? Nationality { get; set; }
   
    public string Image { get; set; }
    
   

    
    [MaxLength(10)]
    public string? Gender { get; set; }

    public DateTime DOB { get; set; }
    public string? BirthCountry { get; set; }
    public string? BirthPlace { get; set; }

    public int Height { get; set; }

    [MaxLength(255)]
    public string Peculiarity { get; set; }

    [MaxLength(255)]
    public string DomicileAddress { get; set; }

    [MaxLength(255)]
    public string AddressDuringSriLanka { get; set; }

    [MaxLength(20)]
    public string Telephone { get; set; }

    [MaxLength(20)]
    public string Mobile { get; set; }
    
    public int periodofvisit{ get; set;}
    
    [MaxLength(100)]
    public string Email { get; set; }
    
    [MaxLength(100)]
    public string WorkSpaceName { get; set; }

    public string WorkSpaceAddress { get; set; }
    
    public string WorkSpaceEmail { get; set; }

    public CivilStatus CivilStatus { get; set; }

    public ICollection<EmergencyContact>? EmergencyContacts { get; set; }

    public NaturalizationInfo? NaturalizationInfo { get; set; }

    public SpouseInfo? Spouse { get; set; }

    public Passport? Passport { get; set; }

    public ICollection<EntryVisaInfo>? EntryVisas { get; set; }

    public ICollection<Children>? Children { get; set; }

    public Profession? Profession { get; set; }

    public ResidenceVisaInfo? ResidenceVisaInfo { get; set; }
    
    [ForeignKey("User")]
    public int UserID { get; set; }
 
    // user extention
}

public enum CivilStatus
{
    Single,
    Married,
    Widowed,
    Divorced
}
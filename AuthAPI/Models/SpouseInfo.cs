using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class SpouseInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int UserInfoId { get; set; }

    [MaxLength(100)]
    public string Fullname { get; set; }

    [MaxLength(50)]
    public string Nationality { get; set; }

    [MaxLength(255)]
    public string PostalAddress { get; set; }

    [MaxLength(20)]
    public string PassportNumber { get; set; }

    public DateTime DateOfExpiry { get; set; }

    public bool IsPrevious { get; set; }

    public UserInfo UserInfo { get; set; }
}
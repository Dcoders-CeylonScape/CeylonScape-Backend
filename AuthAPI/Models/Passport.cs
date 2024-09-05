using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class Passport
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int UserInfoId { get; set; }

    [Required]
    [MaxLength(20)]
    public string Number { get; set; }

    [Required]
    [MaxLength(100)]
    public string PlaceOfIssue { get; set; }

    [Required]
    public DateTime DateOfIssue { get; set; }

    [Required]
    public DateTime DateOfExpiry { get; set; }

    public bool IsPrevious { get; set; }

    public UserInfo UserInfo { get; set; }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class NaturalizationInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    public int UserInfoId { get; set; }

    public bool IsNaturalized { get; set; }

    public DateTime? NaturalizationDate { get; set; }

    [MaxLength(100)]
    public string PlaceOfNaturalization { get; set; }

    [MaxLength(50)]
    public string FormerNationality { get; set; }

    public UserInfo UserInfo { get; set; }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class EntryVisaApproval
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(50)]
    public string VisaNumber { get; set; }

    public DateTime DateIssued { get; set; }

    [MaxLength(50)]
    public string Purpose { get; set; }

    public int EntryVisaInfoId { get; set; }
    public EntryVisaInfo EntryVisaInfo { get; set; }
}
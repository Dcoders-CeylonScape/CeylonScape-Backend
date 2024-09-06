using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class EntryVisaInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(50)]
    public string ObjectOfVisit { get; set; }

    [MaxLength(50)]
    public string ModeOfTravel { get; set; }

    public DateTime DateOfLeaving { get; set; }

    [MaxLength(100)]
    public string LastPlaceOfResidence { get; set; }

    public string LastObtainedVisa { get; set; }
    public DateTime DateOfIssue { get; set; }
    
    public int PeriodOfValidity { get; set; }

    public int PeriodOfVisitVisa { get; set; }

    [MaxLength(50)]
    public string ResidenceVisaNumber { get; set; }

    public string HasRefusedVisa { get; set; }
    


    public ICollection<EntryVisaApproval>? EntryVisaApprovals { get; set; }

    public int UserInfoId { get; set; }
    public UserInfo UserInfo { get; set; }

    public ICollection<VisaExtensionInfo>? VisaExtensionInfos { get; set; }
}
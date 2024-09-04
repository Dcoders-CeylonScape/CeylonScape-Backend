using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AuthAPI.Models;
public class ResidenceVisaInfo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime DateOfArrival { get; set; }

    [MaxLength(255)]
    public string ReasonForApplyingVisa { get; set; }

    [MaxLength(50)]
    public string ApplyingFor { get; set; }

    public string SalaryIncome { get; set; }

    public ICollection<ResidenceVisaApproval> ResidenceVisaApprovals { get; set; }

    public Business Business { get; set; }

    public int UserInfoId { get; set; }
    public UserInfo UserInfo { get; set; }
}
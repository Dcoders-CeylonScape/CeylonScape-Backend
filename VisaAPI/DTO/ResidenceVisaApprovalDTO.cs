using System;
using AuthAPI.Models;

public class ResidenceVisaApprovalDTO
{
    public int Id { get; set; }
    public string VisaNumber { get; set; }
    public DateTime DateIssued { get; set; }
    public string Purpose { get; set; }
    public int ResidenceVisaInfoId { get; set; }

    public static ResidenceVisaApprovalDTO ToDTO(ResidenceVisaApproval residenceVisaApproval)
    {
        return new ResidenceVisaApprovalDTO
        {
            Id = residenceVisaApproval.Id,
            VisaNumber = residenceVisaApproval.VisaNumber,
            DateIssued = residenceVisaApproval.DateIssued,
            Purpose = residenceVisaApproval.Purpose,
            ResidenceVisaInfoId = residenceVisaApproval.ResidenceVisaInfoId
        };
    }

    public static ResidenceVisaApproval FromDTO(ResidenceVisaApprovalDTO dto)
    {
        return new ResidenceVisaApproval
        {
            Id = dto.Id,
            VisaNumber = dto.VisaNumber,
            DateIssued = dto.DateIssued,
            Purpose = dto.Purpose,
            ResidenceVisaInfoId = dto.ResidenceVisaInfoId
        };
    }
}
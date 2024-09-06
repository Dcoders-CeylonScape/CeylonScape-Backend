using System;
using System.Collections.Generic;
using AuthAPI.Models;

public class ResidenceVisaInfoDTO
{
    public int Id { get; set; }
    public DateTime DateOfArrival { get; set; }
    public string ReasonForApplyingVisa { get; set; }
    public string ApplyingFor { get; set; }
    public string SalaryIncome { get; set; }
    public List<ResidenceVisaApprovalDTO>? ResidenceVisaApprovals { get; set; }
    public BusinessDTO? Business { get; set; }
    public int UserInfoId { get; set; }

    public static ResidenceVisaInfoDTO ToDTO(ResidenceVisaInfo residenceVisaInfo)
    {
        return new ResidenceVisaInfoDTO
        {
            Id = residenceVisaInfo.Id,
            DateOfArrival = residenceVisaInfo.DateOfArrival,
            ReasonForApplyingVisa = residenceVisaInfo.ReasonForApplyingVisa,
            ApplyingFor = residenceVisaInfo.ApplyingFor,
            SalaryIncome = residenceVisaInfo.SalaryIncome,
            ResidenceVisaApprovals = residenceVisaInfo.ResidenceVisaApprovals != null
                ? new List<ResidenceVisaApprovalDTO>(residenceVisaInfo.ResidenceVisaApprovals.Select(rva => ResidenceVisaApprovalDTO.ToDTO(rva)))
                : new List<ResidenceVisaApprovalDTO>(),
            Business = residenceVisaInfo.Business != null
                ? BusinessDTO.ToDTO(residenceVisaInfo.Business)
                : null,
            UserInfoId = residenceVisaInfo.UserInfoId
        };
    }

    public static ResidenceVisaInfo FromDTO(ResidenceVisaInfoDTO dto)
    {
        return new ResidenceVisaInfo
        {
            Id = dto.Id,
            DateOfArrival = dto.DateOfArrival,
            ReasonForApplyingVisa = dto.ReasonForApplyingVisa,
            ApplyingFor = dto.ApplyingFor,
            SalaryIncome = dto.SalaryIncome,
            ResidenceVisaApprovals = dto.ResidenceVisaApprovals != null
                ? new List<ResidenceVisaApproval>(dto.ResidenceVisaApprovals.Select(rva => ResidenceVisaApprovalDTO.FromDTO(rva)))
                : new List<ResidenceVisaApproval>(),
            Business = dto.Business != null
                ? BusinessDTO.FromDTO(dto.Business)
                : null,
            UserInfoId = dto.UserInfoId
        };
    }
}

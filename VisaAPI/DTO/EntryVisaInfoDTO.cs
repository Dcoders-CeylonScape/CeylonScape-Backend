using System;
using System.Collections.Generic;
using AuthAPI.Models;

public class EntryVisaInfoDTO
{
    public int Id { get; set; }
    
    public string ModeOfTravel { get; set; }
    public DateTime DateOfLeaving { get; set; }
    public string LastPlaceOfResidence { get; set; }
    public DateTime DateOfIssue { get; set; }
    public string ResidenceVisaNumber { get; set; }
    public string HasRefusedVisa { get; set; }

    public string ObjectOfVisit { get; set; }

    public int PeriodOfVisitVisa { get; set; }
    public int PeriodOfValidity { get; set; }
    public int UserInfoId { get; set; }
    
    public string LastObtainedVisa { get; set; }
    public List<EntryVisaApprovalDTO>? EntryVisaApprovals { get; set; }
    public List<VisaExtensionInfoDTO>? VisaExtensionInfos { get; set; }

    public static EntryVisaInfoDTO ToDTO(EntryVisaInfo entryVisaInfo)
    {
        return new EntryVisaInfoDTO
        {
            Id = entryVisaInfo.Id,
            PeriodOfValidity=entryVisaInfo.PeriodOfValidity,
            LastObtainedVisa=entryVisaInfo.LastObtainedVisa,
            ModeOfTravel = entryVisaInfo.ModeOfTravel,
            PeriodOfVisitVisa= entryVisaInfo.PeriodOfVisitVisa,
            DateOfLeaving = entryVisaInfo.DateOfLeaving,
            LastPlaceOfResidence = entryVisaInfo.LastPlaceOfResidence,
            DateOfIssue = entryVisaInfo.DateOfIssue,
            ResidenceVisaNumber = entryVisaInfo.ResidenceVisaNumber,
            HasRefusedVisa = entryVisaInfo.HasRefusedVisa,
            ObjectOfVisit= entryVisaInfo.ObjectOfVisit,
            UserInfoId = entryVisaInfo.UserInfoId,
            EntryVisaApprovals = entryVisaInfo.EntryVisaApprovals != null
                ? new List<EntryVisaApprovalDTO>(entryVisaInfo.EntryVisaApprovals.Select(eva => EntryVisaApprovalDTO.ToDTO(eva)))
                : new List<EntryVisaApprovalDTO>(),
            VisaExtensionInfos = entryVisaInfo.VisaExtensionInfos != null
                ? new List<VisaExtensionInfoDTO>(entryVisaInfo.VisaExtensionInfos.Select(vei => VisaExtensionInfoDTO.ToDTO(vei)))
                : new List<VisaExtensionInfoDTO>()
        };
    }

    public static EntryVisaInfo FromDTO(EntryVisaInfoDTO dto)
    {
        return new EntryVisaInfo
        {
            Id = dto.Id,
            PeriodOfValidity=dto.PeriodOfValidity,
            LastObtainedVisa=dto.LastObtainedVisa,
            ModeOfTravel = dto.ModeOfTravel,
            DateOfLeaving = dto.DateOfLeaving,
            ObjectOfVisit = dto.ObjectOfVisit,
            PeriodOfVisitVisa= dto.PeriodOfVisitVisa,
            LastPlaceOfResidence = dto.LastPlaceOfResidence,
            DateOfIssue = dto.DateOfIssue,
            ResidenceVisaNumber = dto.ResidenceVisaNumber,
            HasRefusedVisa = dto.HasRefusedVisa,
            UserInfoId = dto.UserInfoId,
            EntryVisaApprovals = dto.EntryVisaApprovals != null
                ? new List<EntryVisaApproval>(dto.EntryVisaApprovals.Select(eva => EntryVisaApprovalDTO.FromDTO(eva)))
                : new List<EntryVisaApproval>(),
            VisaExtensionInfos = dto.VisaExtensionInfos != null
                ? new List<VisaExtensionInfo>(dto.VisaExtensionInfos.Select(vei => VisaExtensionInfoDTO.FromDTO(vei)))
                : new List<VisaExtensionInfo>()
        };
    }
}

using System;
using AuthAPI.Models;

public class EntryVisaApprovalDTO
{
    public int Id { get; set; }
    public string VisaNumber { get; set; }
    public DateTime DateIssued { get; set; }
    public string Purpose { get; set; }
    public int EntryVisaInfoId { get; set; }

    public static EntryVisaApprovalDTO ToDTO(EntryVisaApproval entryVisaApproval)
    {
        return new EntryVisaApprovalDTO
        {
            Id = entryVisaApproval.Id,
            VisaNumber = entryVisaApproval.VisaNumber,
            DateIssued = entryVisaApproval.DateIssued,
            Purpose = entryVisaApproval.Purpose,
            EntryVisaInfoId = entryVisaApproval.EntryVisaInfoId
        };
    }

    public static EntryVisaApproval FromDTO(EntryVisaApprovalDTO dto)
    {
        return new EntryVisaApproval
        {
            Id = dto.Id,
            VisaNumber = dto.VisaNumber,
            DateIssued = dto.DateIssued,
            Purpose = dto.Purpose,
            EntryVisaInfoId = dto.EntryVisaInfoId
        };
    }
}
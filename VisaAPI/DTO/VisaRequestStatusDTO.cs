using System;
using AuthAPI.Models;

public class VisaRequestStatusDTO
{
    public int Id { get; set; }
    public string Reason { get; set; }
    public string Flag { get; set; }
    public string Status { get; set; }
    public int AdminId { get; set; }

    public static VisaRequestStatusDTO ToDTO(VisaRequestStatus visaRequestStatus)
    {
        return new VisaRequestStatusDTO
        {
            Id = visaRequestStatus.Id,
            Reason = visaRequestStatus.Reason,
            Flag = visaRequestStatus.Flag,
            Status = visaRequestStatus.Status,
            AdminId = visaRequestStatus.AdminId
        };
    }

    public static VisaRequestStatus FromDTO(VisaRequestStatusDTO dto)
    {
        return new VisaRequestStatus
        {
            Id = dto.Id,
            Reason = dto.Reason,
            Flag = dto.Flag,
            Status = dto.Status,
            AdminId = dto.AdminId
        };
    }
}
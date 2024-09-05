using System;
using AuthAPI.Models;

public class NaturalizationInfoDTO
{
    public int UserInfoId { get; set; }
    public bool IsNaturalized { get; set; }
    public DateTime? NaturalizationDate { get; set; }
    public string PlaceOfNaturalization { get; set; }
    public string FormerNationality { get; set; }

    public static NaturalizationInfoDTO ToDTO(NaturalizationInfo naturalizationInfo)
    {
        return new NaturalizationInfoDTO
        {
            UserInfoId = naturalizationInfo.UserInfoId,
            IsNaturalized = naturalizationInfo.IsNaturalized,
            NaturalizationDate = naturalizationInfo.NaturalizationDate,
            PlaceOfNaturalization = naturalizationInfo.PlaceOfNaturalization,
            FormerNationality = naturalizationInfo.FormerNationality
        };
    }

    public static NaturalizationInfo FromDTO(NaturalizationInfoDTO dto)
    {
        return new NaturalizationInfo
        {
            UserInfoId = dto.UserInfoId,
            IsNaturalized = dto.IsNaturalized,
            NaturalizationDate = dto.NaturalizationDate,
            PlaceOfNaturalization = dto.PlaceOfNaturalization,
            FormerNationality = dto.FormerNationality
        };
    }
}
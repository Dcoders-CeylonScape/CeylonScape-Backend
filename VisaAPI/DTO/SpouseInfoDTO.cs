using System;
using AuthAPI.Models;

public class SpouseInfoDTO
{
    public int UserInfoId { get; set; }
    public string Fullname { get; set; }
    public string Nationality { get; set; }
    public string PostalAddress { get; set; }
    public string PassportNumber { get; set; }
    public DateTime DateOfExpiry { get; set; }
  

    public static SpouseInfoDTO ToDTO(SpouseInfo spouseInfo)
    {
        return new SpouseInfoDTO
        {
            UserInfoId = spouseInfo.UserInfoId,
            Fullname = spouseInfo.Fullname,
            Nationality = spouseInfo.Nationality,
            PostalAddress = spouseInfo.PostalAddress,
            PassportNumber = spouseInfo.PassportNumber,
            DateOfExpiry = spouseInfo.DateOfExpiry,
            
        };
    }

    public static SpouseInfo FromDTO(SpouseInfoDTO dto)
    {
        return new SpouseInfo
        {
            UserInfoId = dto.UserInfoId,
            Fullname = dto.Fullname,
            Nationality = dto.Nationality,
            PostalAddress = dto.PostalAddress,
            PassportNumber = dto.PassportNumber,
            DateOfExpiry = dto.DateOfExpiry,
     
        };
    }
}
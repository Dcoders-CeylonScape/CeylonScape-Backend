using System;
using AuthAPI.Models;

public class ProfessionDTO
{
    public int Id { get; set; }
    public string NameOfWorkplace { get; set; }
    public string AddressOfWorkplace { get; set; }
    public string Email { get; set; }
    public string Fax { get; set; }
    public int UserInfoId { get; set; }

    public static ProfessionDTO ToDTO(Profession profession)
    {
        return new ProfessionDTO
        {
            Id = profession.Id,
            NameOfWorkplace = profession.NameOfWorkplace,
            AddressOfWorkplace = profession.AddressOfWorkplace,
            Email = profession.Email,
            Fax = profession.Fax,
            UserInfoId = profession.UserInfoId
        };
    }

    public static Profession FromDTO(ProfessionDTO dto)
    {
        return new Profession
        {
            Id = dto.Id,
            NameOfWorkplace = dto.NameOfWorkplace,
            AddressOfWorkplace = dto.AddressOfWorkplace,
            Email = dto.Email,
            Fax = dto.Fax,
            UserInfoId = dto.UserInfoId
        };
    }
}
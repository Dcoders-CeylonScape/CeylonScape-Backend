using System;
using AuthAPI.Models;


public class EmergencyContactDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; }
    public string Relationship { get; set; }
    public bool IsSrilanka { get; set; }
    public int UserInfoId { get; set; }

    public static EmergencyContactDTO ToDTO(AuthAPI.Models.EmergencyContact emergencyContract )
    {
        return new EmergencyContactDTO
        {
            Id = emergencyContract.Id,
            Name = emergencyContract.Name,
            Address = emergencyContract.Address,
            Contact = emergencyContract.Contact,
            Relationship = emergencyContract.Relationship,
            IsSrilanka = emergencyContract.IsSrilanka,
            UserInfoId = emergencyContract.UserInfoId
        };
    }

    public static EmergencyContact FromDTO(EmergencyContactDTO dto)
    {
        return new EmergencyContact
        {
            Id = dto.Id,
            Name = dto.Name,
            Address = dto.Address,
            Contact = dto.Contact,
            Relationship = dto.Relationship,
            IsSrilanka = dto.IsSrilanka,
            UserInfoId = dto.UserInfoId
        };
    }


}

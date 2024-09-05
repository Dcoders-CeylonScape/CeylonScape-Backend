using System;
using AuthAPI.Models;


public class EmergencyContactDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; }
    public string Relationship { get; set; }
    public int UserInfoId { get; set; }
    public string nameOfCreditCard { get; set; }
    public string Support { get; set; }
    public double SpendableAmount { get; set; }
    public double UsdAmount { get; set; }

    public static EmergencyContactDTO ToDTO(AuthAPI.Models.EmergencyContact emergencyContract )
    {
        return new EmergencyContactDTO
        {
            Id = emergencyContract.Id,
            nameOfCreditCard=emergencyContract.nameOfCreditCard,
            Name = emergencyContract.Name,
            Address = emergencyContract.Address,
            Contact = emergencyContract.Contact,
            UsdAmount=emergencyContract.UsdAmount,
            Relationship = emergencyContract.Relationship,
            UserInfoId = emergencyContract.UserInfoId,
            Support = emergencyContract.Support,
            SpendableAmount=emergencyContract.SpendableAmount
        };
    }

    public static EmergencyContact FromDTO(EmergencyContactDTO dto)
    {
        return new EmergencyContact
        {
            Id = dto.Id,
            Name = dto.Name,
            nameOfCreditCard=dto.nameOfCreditCard,
            SpendableAmount=dto.SpendableAmount,
            Address = dto.Address,
            Contact = dto.Contact,
            Support= dto.Support,
            UsdAmount=dto.UsdAmount,
            Relationship = dto.Relationship,
            UserInfoId = dto.UserInfoId
        };
    }


}

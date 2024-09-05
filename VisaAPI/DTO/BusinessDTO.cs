using System;
using AuthAPI.Models;

public class BusinessDTO
{
    public int Id { get; set; }
    public string NameOfBusiness { get; set; }
    public string AddressOfBusiness { get; set; }
    public string RegistrationNumber { get; set; }
    public string SharesOwned { get; set; }
    public int ResidenceVisaInfoId { get; set; }

    public static BusinessDTO ToDTO(Business business)
    {
        return new BusinessDTO
        {
            Id = business.Id,
            NameOfBusiness = business.NameOfBusiness,
            AddressOfBusiness = business.AddressOfBusiness,
            RegistrationNumber = business.RegistrationNumber,
            SharesOwned = business.SharesOwned,
            ResidenceVisaInfoId = business.ResidenceVisaInfoId
        };
    }

    public static Business FromDTO(BusinessDTO dto)
    {
        return new Business
        {
            Id = dto.Id,
            NameOfBusiness = dto.NameOfBusiness,
            AddressOfBusiness = dto.AddressOfBusiness,
            RegistrationNumber = dto.RegistrationNumber,
            SharesOwned = dto.SharesOwned,
            ResidenceVisaInfoId = dto.ResidenceVisaInfoId
        };
    }
}
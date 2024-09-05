using System;
using AuthAPI.Models;

public class PassportDTO
{
    public int UserInfoId { get; set; }
    public string Number { get; set; }
    public string PlaceOfIssue { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }
    
    public string PreviousPlaceOfIssue { get; set; }
    
    public string PreviousNumber { get; set; }
    
    public DateTime PreviousDateOfExpiry { get; set; }
    public DateTime PreviousDateOfIssue { get; set; }
   

    public static PassportDTO ToDTO(Passport passport)
    {
        return new PassportDTO
        {
            UserInfoId = passport.UserInfoId,
            PreviousPlaceOfIssue=passport.PreviousPlaceOfIssue,
            PreviousDateOfIssue=passport.PreviousDateOfIssue,
            Number = passport.Number,
            PreviousDateOfExpiry=passport.PreviousDateOfExpiry,
            PreviousNumber=passport.PreviousNumber,
            PlaceOfIssue = passport.PlaceOfIssue,
            DateOfIssue = passport.DateOfIssue,
            DateOfExpiry = passport.DateOfExpiry,
       
        };
    }

    public static Passport FromDTO(PassportDTO dto)
    {
        return new Passport
        {
            UserInfoId = dto.UserInfoId,
            Number = dto.Number,
            PreviousPlaceOfIssue = dto.PreviousPlaceOfIssue,
            PreviousDateOfExpiry=dto.PreviousDateOfExpiry,
            PreviousDateOfIssue = dto.PreviousDateOfIssue,
            PreviousNumber = dto.PreviousNumber,
            PlaceOfIssue = dto.PlaceOfIssue,
            DateOfIssue = dto.DateOfIssue,
            DateOfExpiry = dto.DateOfExpiry,
          
        };
    }
}
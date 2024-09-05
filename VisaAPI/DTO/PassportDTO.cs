using System;
using AuthAPI.Models;

public class PassportDTO
{
    public int UserInfoId { get; set; }
    public string Number { get; set; }
    public string PlaceOfIssue { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }
    public bool IsPrevious { get; set; }

    public static PassportDTO ToDTO(Passport passport)
    {
        return new PassportDTO
        {
            UserInfoId = passport.UserInfoId,
            Number = passport.Number,
            PlaceOfIssue = passport.PlaceOfIssue,
            DateOfIssue = passport.DateOfIssue,
            DateOfExpiry = passport.DateOfExpiry,
            IsPrevious = passport.IsPrevious
        };
    }

    public static Passport FromDTO(PassportDTO dto)
    {
        return new Passport
        {
            UserInfoId = dto.UserInfoId,
            Number = dto.Number,
            PlaceOfIssue = dto.PlaceOfIssue,
            DateOfIssue = dto.DateOfIssue,
            DateOfExpiry = dto.DateOfExpiry,
            IsPrevious = dto.IsPrevious
        };
    }
}
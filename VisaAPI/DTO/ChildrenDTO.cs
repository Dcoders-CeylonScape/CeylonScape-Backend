using System;
using AuthAPI.Models;

public class ChildrenDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string PlaceOfBirth { get; set; }
    public int UserInfoId { get; set; }

    public static ChildrenDTO ToDTO(Children child)
    {
        return new ChildrenDTO
        {
            Id = child.Id,
            Name = child.Name,
            Gender = child.Gender,
            PlaceOfBirth = child.PlaceOfBirth,
            UserInfoId = child.UserInfoId
        };
    }

    public static Children FromDTO(ChildrenDTO dto)
    {
        return new Children
        {
            Id = dto.Id,
            Name = dto.Name,
            Gender = dto.Gender,
            PlaceOfBirth = dto.PlaceOfBirth,
            UserInfoId = dto.UserInfoId
        };
    }
}
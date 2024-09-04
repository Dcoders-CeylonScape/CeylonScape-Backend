using System.ComponentModel.DataAnnotations;
using AuthAPI.Models;

namespace AuthAPI.DTO;

public class UserDTO
{
    [Required] public int UserID { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string MobileNumber { get; set; } = string.Empty;
    
    public int AccountVerified { get; set; } = 0;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
    
    public static UserDTO FromUser(User user)
    {
        return new UserDTO
        {
            UserID = user.UserID,
            FirstName = user.FirstName,
            LastName = user.LastName,
            MobileNumber = user.MobileNumber,
            Email = user.Email,
            AccountVerified = user.AccountVerified
        };
    }

    // userDTO to user
    public User ToUser()
    {
        return new User
        {
            FirstName = FirstName,
            LastName = LastName,
            MobileNumber = MobileNumber,
            Email = Email,
            Password = Password,
            AccountVerified = AccountVerified
        };
    }
}
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public required string Nic { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required int AccountVerified { get; set; }
        public required string MobileNumber { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string[]? OldPassword { get; set; }
    }
}

using AuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI;

public class AuthAPIContext : DbContext
{
    public AuthAPIContext(DbContextOptions<AuthAPIContext> options) : base(options)
    {
    }

    public DbSet<User> User { get; set; } = null!;
    

}
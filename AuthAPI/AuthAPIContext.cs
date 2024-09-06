
using AuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI;

public class AuthAPIContext : DbContext
{
    public AuthAPIContext(DbContextOptions<AuthAPIContext> options) : base(options)
    {
    }

    public DbSet<UserInfo> UserInfos { get; set; }
    public DbSet<EmergencyContact> EmergencyContacts { get; set; }
    public DbSet<NaturalizationInfo> NaturalizationInfos { get; set; }
    public DbSet<SpouseInfo> SpouseInfos { get; set; }
    public DbSet<Passport> Passports { get; set; }
    public DbSet<EntryVisaInfo> EntryVisaInfos { get; set; }
    public DbSet<EntryVisaApproval> EntryVisaApprovals { get; set; }
    public DbSet<ResidenceVisaInfo> ResidenceVisaInfos { get; set; }
    public DbSet<ResidenceVisaApproval> ResidenceVisaApprovals { get; set; }
    public DbSet<Children> Childrens { get; set; }
    public DbSet<Profession> Professions { get; set; }
    public DbSet<Business> Businesses { get; set; }
    public DbSet<VisaExtensionInfo> VisaExtensionInfos { get; set; }
    public DbSet<User> User { get; set; } = null!;
    public DbSet<VisaRequestStatus> Statuses { get; set; } = null!;

    public DbSet<Admin> Admins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserInfo>()
            .HasOne(u => u.NaturalizationInfo)
            .WithOne(n => n.UserInfo)
            .HasForeignKey<NaturalizationInfo>(n => n.UserInfoId);

        modelBuilder.Entity<UserInfo>()
            .HasOne(u => u.Spouse)
            .WithOne(s => s.UserInfo)
            .HasForeignKey<SpouseInfo>(s => s.UserInfoId);

        modelBuilder.Entity<UserInfo>()
            .HasOne(u => u.Passport)
            .WithOne(p => p.UserInfo)
            .HasForeignKey<Passport>(p => p.UserInfoId);

        modelBuilder.Entity<UserInfo>()
            .HasMany(u => u.EmergencyContacts)
            .WithOne(e => e.UserInfo)
            .HasForeignKey(e => e.UserInfoId);

        modelBuilder.Entity<UserInfo>()
            .HasMany(u => u.EntryVisas)
            .WithOne(e => e.UserInfo)
            .HasForeignKey(e => e.UserInfoId);
        

        modelBuilder.Entity<UserInfo>()
            .HasOne(u => u.Profession)
            .WithOne(p => p.UserInfo)
            .HasForeignKey<Profession>(p => p.UserInfoId);

        modelBuilder.Entity<EntryVisaInfo>()
            .HasMany(e => e.EntryVisaApprovals)
            .WithOne(p => p.EntryVisaInfo)
            .HasForeignKey(p => p.EntryVisaInfoId);

        modelBuilder.Entity<EntryVisaInfo>()
            .HasMany(e => e.VisaExtensionInfos)
            .WithOne(v => v.EntryVisaInfo)
            .HasForeignKey(v => v.EntryVisaInfoId);

        modelBuilder.Entity<ResidenceVisaInfo>()
            .HasMany(r => r.ResidenceVisaApprovals)
            .WithOne(p => p.ResidenceVisaInfo)
            .HasForeignKey(p => p.ResidenceVisaInfoId);

        modelBuilder.Entity<ResidenceVisaInfo>()
            .HasOne(r => r.Business)
            .WithOne(b => b.ResidenceVisaInfo)
            .HasForeignKey<Business>(b => b.ResidenceVisaInfoId);
    }
    


}
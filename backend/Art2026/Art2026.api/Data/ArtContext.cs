using Art2026.Models;
using Microsoft.EntityFrameworkCore;

namespace Art2026.Data
{
    public class ArtContext : DbContext
    {
        public ArtContext(DbContextOptions<ArtContext> options) : base(options) { }

        public DbSet<Manifestation> Manifestations { get; set; }
        public DbSet<ManifestationDay> ManifestationDays { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RegistrationDay> RegistrationDays { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistrationDay>()
                .HasKey(x => new { x.RegistrationId, x.ManifestationDayId });

            modelBuilder.Entity<RegistrationDay>()
                .HasOne(x => x.Registration)
                .WithMany(r => r.RegistrationDays)
                .HasForeignKey(x => x.RegistrationId);

            modelBuilder.Entity<RegistrationDay>()
                .HasOne(x => x.ManifestationDay)
                .WithMany(d => d.RegistrationDays)
                .HasForeignKey(x => x.ManifestationDayId);

            modelBuilder.Entity<PromoCode>()
                .HasOne(p => p.Registration)
                .WithOne(r => r.GeneratedPromoCode)
                .HasForeignKey<PromoCode>(p => p.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PromoCode>()
                .HasOne(p => p.UsedByRegistration)
                .WithMany()
                .HasForeignKey(p => p.UsedByRegistrationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.UsedPromoCode)
                .WithMany()
                .HasForeignKey(r => r.UsedPromoCodeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Registration>()
                .HasIndex(r => r.AccessToken)
                .IsUnique();

            modelBuilder.Entity<PromoCode>()
                .HasIndex(p => p.Code)
                .IsUnique();
        }
    }
}

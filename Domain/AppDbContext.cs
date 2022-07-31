using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using real_estate.Domain.Entities;

namespace real_estate.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "dd085438-398b-4193-8261-8889274cd2e3",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "247c15c0-434e-4e2c-bd63-367a2cc1be2a",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "user@mail.ru",
                NormalizedEmail = "USER@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "userpass"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "dd085438-398b-4193-8261-8889274cd2e3",
                UserId = "247c15c0-434e-4e2c-bd63-367a2cc1be2a"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("22b7ed51-e608-476d-a83c-23d458597891"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("72add0a7-9fe3-486b-be74-f1d7571d0eed"),
                CodeWord = "PageServices",
                Title = "Недвижимость"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("47c42a9d-6764-4e6d-816f-4c927515a60b"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }

    }
}

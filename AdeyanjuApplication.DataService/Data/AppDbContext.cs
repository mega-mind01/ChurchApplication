using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Data
{
    public class AppDbContext : IdentityDbContext<Members, IdentityRole<string>, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole<string>>().HasData(new IdentityRole<string>
            {
                Id = "1",
                Name = "Pastor",
                NormalizedName = "PASTOR",

            }, new IdentityRole<string>
            {
                Id = "2",
                Name = "Evangelist",
                NormalizedName = "EVANGELIST",
            }, new IdentityRole<string>
            {
                Id = "3",
                Name = "Elder",
                NormalizedName = "ELDER",
            }, new IdentityRole<string>
            {
                Id = "4",
                Name = "Deacon",
                NormalizedName = "DEACON",
            }, new IdentityRole<string>
            {
                Id = "5",
                Name = "Deaconess",
                NormalizedName = "DEACONESS",
            }, new IdentityRole<string>
            {
                Id = "6",
                Name = "Member",
                NormalizedName = "MEMBER",
            });

            builder.Entity<Members>().HasData(new Members
            {
                FirstName = "Timothy",
                LastName = "Meleki",
                Email = "muyiwameleki@gmail.com",
                NormalizedEmail = "MUYIWAMELEKI@GMAIL.COM",
                Id = "1",
                UserName = "muyiwameleki@gmail.com",
                NormalizedUserName = "MUYIWAMELEKI@GMAIL.COM",
                PasswordHash = new PasswordHasher<Members>().HashPassword(null, "Timothy@123"),
                UserRoleId = "1",
                SecurityStamp = Guid.NewGuid().ToString()
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "1",
            });
        }

        

        DbSet<Pastor> Pastors { get; set; }
        DbSet<Evangelist> Evangelists { get; set; }
        DbSet<Members> Members { get; set; }
        DbSet<Announcement> Announcements { get; set; }
        DbSet<ChurchActivity> ChurchActivities { get; set;}
    }
}

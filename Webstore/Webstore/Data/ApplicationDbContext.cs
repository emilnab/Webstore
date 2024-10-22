using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webstore.Models;

namespace Webstore.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Category { get; set; }

        public DbSet<Ware> Ware { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            FileStream FS = new FileStream("../Webstore/wwwroot/Images/console.jpg", FileMode.Open, FileAccess.Read);
            byte[] img = new byte[FS.Length];
            FS.Read(img, 0, Convert.ToInt32(FS.Length));

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Konsol" },
                new Category { Id = 2, Name = "Frugt" });

            builder.Entity<Ware>().HasData(
                new Ware
                {
                    Id = 1,
                    Name = "Playstation 4",
                    Description = "Den popul�re konsol fra Sony",
                    Price = 1000,
                    Photo = img
                },
                new Ware
                {
                    Id = 2,
                    Name = "�ble",
                    Description = "Et �ble",
                    Price = 5,
                    Photo = img
                },
                 new Ware
                 {
                     Id = 3,
                     Name = "Playstation 4",
                     Description = "Den popul�re konsol fra Sony",
                     Price = 1000,
                     Photo = img
                 },
                  new Ware
                  {
                      Id = 4,
                      Name = "Playstation 4",
                      Description = "Den popul�re konsol fra Sony",
                      Price = 1000,
                      Photo = img
                  },
                  new Ware
                  {
                      Id = 5,
                      Name = "Playstation 4",
                      Description = "Den popul�re konsol fra Sony",
                      Price = 1000,
                      Photo = img
                  },
                  new Ware
                  {
                      Id = 6,
                      Name = "Playstation 4",
                      Description = "Den popul�re konsol fra Sony",
                      Price = 1000,
                      Photo = img
                  },
                     new Ware
                     {
                         Id = 7,
                         Name = "Playstation 4",
                         Description = "Den popul�re konsol fra Sony",
                         Price = 1000,
                         Photo = img
                     },
                      new Ware
                      {
                          Id = 8,
                          Name = "Playstation 4",
                          Description = "Den popul�re konsol fra Sony",
                          Price = 1000,
                          Photo = img
                      },
                       new Ware
                       {
                           Id = 9,
                           Name = "Playstation 4",
                           Description = "Den popul�re konsol fra Sony",
                           Price = 1000,
                           Photo = img
                       },
                        new Ware
                        {
                            Id = 10,
                            Name = "Playstation 4",
                            Description = "Den popul�re konsol fra Sony",
                            Price = 1000,
                            Photo = img
                        }

                );
            base.OnModelCreating(builder); // -> https://stackoverflow.com/questions/40703615/the-entity-type-identityuserloginstring-requires-a-primary-key-to-be-defined
        }

    }
}

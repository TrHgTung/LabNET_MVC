using Microsoft.EntityFrameworkCore;

namespace Tung.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                        new Product
                        {
                            Name = "book",
                            Description = "for student",
                            Category = "Education",
                            Price = 100000
                        },
                         new Product
                         {
                             Name = "book2",
                             Description = "for student",
                             Category = "Education",
                             Price = 100000
                         },
                          new Product
                          {
                              Name = "book3",
                              Description = "for student",
                              Category = "Education",
                              Price = 100000
                          },
                           new Product
                           {
                               Name = "book4",
                               Description = "for student",
                               Category = "Education",
                               Price = 100000
                           },
                            new Product
                            {
                                Name = "book5",
                                Description = "for student",
                                Category = "Education",
                                Price = 100000
                            }
                    );
                context.SaveChanges();
            }
        }
    }
}

using LiveLibUaVersionMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace LiveLibUaVersionMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LiveLibUaVersionMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LiveLibUaVersionMVCContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return; // Db has been seeded.
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Першому гравцеві приготуватися",
                        Author = "Ернест Клайн",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Фантастика",
                        Price = 400,
                        ReadingStart = DateTime.Parse("2021-1-12"),
                        ReadingFinish = DateTime.Parse("2021-30-12")
                    },

                    new Book
                    {
                        Title = "Майстер та Маргарита",
                        Author = "Михаил Буглаков",
                        ReleaseDate = DateTime.Parse("1921-2-12"),
                        Genre = "Класика",
                        Price = 210,
                        ReadingStart = DateTime.Parse("2021-1-12"),
                        ReadingFinish = DateTime.Parse("2021-30-12")
                    },

                    new Book
                    {
                        Title = "Мартін Іден",
                        Author = "Джек Лондон",
                        ReleaseDate = DateTime.Parse("1941-2-12"),
                        Genre = "Класика",
                        Price = 180,
                        ReadingStart = DateTime.Parse("2021-1-12"),
                        ReadingFinish = DateTime.Parse("2021-30-12")
                    },

                    new Book
                    {
                        Title = "Степовий вовк",
                        Author = "Герман Гессе",
                        ReleaseDate = DateTime.Parse("1913-2-12"),
                        Genre = "Класика",
                        Price = 450,
                        ReadingStart = DateTime.Parse("2021-1-12"),
                        ReadingFinish = DateTime.Parse("2021-30-12")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

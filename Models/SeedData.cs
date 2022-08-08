using LiveLibUaVersionMVC.Data;

namespace LiveLibUaVersionMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibraryContext>>()))
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
                        ReleaseDate = DateTime.Parse("2011-9-16"),
                        Genre = "Фантастика",
                        Price = 400,
                        ReadingStart = DateTime.Parse("2021-1-12"),
                        ReadingFinish = DateTime.Parse("2021-12-30")
                    },

                    new Book
                    {
                        Title = "Майстер та Маргарита",
                        Author = "Михаил Буглаков",
                        ReleaseDate = DateTime.Parse("1967-1-1"),
                        Genre = "Класика",
                        Price = 210,
                        ReadingStart = DateTime.Parse("2021-11-15"),
                        ReadingFinish = DateTime.Parse("2021-11-30")
                    },

                    new Book
                    {
                        Title = "Мартін Іден",
                        Author = "Джек Лондон",
                        ReleaseDate = DateTime.Parse("1909-1-1"),
                        Genre = "Класика",
                        Price = 180,
                        ReadingStart = DateTime.Parse("2021-1-11"),
                        ReadingFinish = DateTime.Parse("2021-11-14")
                    },

                    new Book
                    {
                        Title = "Степовий вовк",
                        Author = "Герман Гессе",
                        ReleaseDate = DateTime.Parse("1927-12-2"),
                        Genre = "Класика",
                        Price = 450,
                        ReadingStart = DateTime.Parse("2021-10-5"),
                        ReadingFinish = DateTime.Parse("2021-10-27")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

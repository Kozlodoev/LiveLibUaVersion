using System.ComponentModel.DataAnnotations.Schema;

namespace LiveLibUaVersionMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Назва"), Required, StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }

        [Display(Name = "Автор"), Required, StringLength(60, MinimumLength = 3)]
        public string? Author { get; set; }

        [Display(Name = "Дата написання"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр"), Required, StringLength(30)]
        public string? Genre { get; set; }

        [Display(Name = "Ціна"), DataType(DataType.Currency), Range(1, 2000)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }

        [Display(Name = "Почав читати"), DataType(DataType.Date)]
        public DateTime? ReadingStart { get; set; }

        [Display(Name = "Закінчив читати"), DataType(DataType.Date)]
        public DateTime? ReadingFinish { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Costea_Maria_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Autor { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

    }
}

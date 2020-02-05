namespace LibraryCMS.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Book
    {
        public int BookId { get; set; }
        [StringLength(100)] public string BookName { get; set; }

        [ForeignKey("TblAuthors")] public string AuthorId { get; set; }
        [ForeignKey("TblCategories")] public string CategoryId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Isbn { get; set; }

        public Author BookAuthor { get; set; }
    }
}
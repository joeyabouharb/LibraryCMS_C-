namespace LibraryCMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Loan
    {
        public int LoanId { get; set; }
        public DateTime DueDate { get; set; }
        [ForeignKey("TblBooks")]
        public int BookId { get; set; }
        [ForeignKey("TblAuthors")]
        public int AuthorId {get; set; }
    }
}